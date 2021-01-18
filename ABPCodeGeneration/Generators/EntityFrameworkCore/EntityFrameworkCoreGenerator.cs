using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ABPCodeGeneration.Generators
{
    public class EntityFrameworkCoreGenerator : AbsGenerator
    {
        public override string GetDir()
        {
            return $@"{GetBasePath()}\{ClassInfo.Namespace.Split('.')[0]}.EntityFrameworkCore\";
        }
        public override string GetPath()
        {
            return $@"{GetBasePath()}\{ClassInfo.Namespace.Split('.')[0]}.EntityFrameworkCore\EntityFrameworkCore\{ClassInfo.Namespace.Split('.')[0]}DbContext.cs";

        }

        public override string GetTemplet()
        {
            var templet = new StringBuilder();
            var count = 0;
            try
            {
                var path = GetPath();
                var all = string.Empty;
                using (StreamReader sr = new StreamReader(path))
                {
                    all = sr.ReadToEnd();
                }
                using (StreamReader sr = new StreamReader(path))
                {
                    var temp = $@"        public DbSet<{ClassInfo.Name}>{ClassInfo.Name}s {{ get; set; }}";
                    if (!all.Contains(temp.Trim()))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            templet.AppendLine(line);
                            if (line.Contains("{"))
                            {
                                count++;
                            }
                            if (count == 2)
                            {
                                templet.AppendLine(temp);
                                count++;
                            }

                        }
                    }

                }
            }
            catch (Exception e)
            {
                // 向用户显示出错消息
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return templet.ToString();
        }
    }
}
