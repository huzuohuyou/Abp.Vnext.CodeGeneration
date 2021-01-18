using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPCodeGeneration.Generators
{
    /// <summary>
    /// 修改ApplicationAutoMapperProfile文件
    /// </summary>
    public class ApplicationAutoMapperProfileGenerator : AbsGenerator
    {
        public override string GetDir()
        {
            return $@"{GetBasePath()}\{ClassInfo.Namespace.Split('.')[0]}.Application\";
        }
        public override string GetPath()
        {
            return $@"{GetBasePath()}\{ClassInfo.Namespace.Split('.')[0]}.Application\{ClassInfo.Namespace.Split('.')[0]}ApplicationAutoMapperProfile.cs";

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
                    var temp = $@"            CreateMap<{ClassInfo.Name}, {ClassInfo.Name}Dto>();";
                    var ok1 = all.Contains(temp.Trim());
                    var temp2 = $@"            CreateMap<CreateUpdate{ClassInfo.Name}Dto, {ClassInfo.Name}>();";
                    var ok2 = all.Contains(temp2.Trim());

                    string line;
                    // 从文件读取并显示行，直到文件的末尾 
                    while ((line = sr.ReadLine()) != null)
                    {
                        templet.AppendLine(line);
                        if (line.Contains("{"))
                        {
                            count++;
                        }
                        if (count == 3)
                        {
                            if (!ok1)
                                templet.AppendLine(temp);

                            if (!ok2)
                                templet.AppendLine(temp2);

                            count++;
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
