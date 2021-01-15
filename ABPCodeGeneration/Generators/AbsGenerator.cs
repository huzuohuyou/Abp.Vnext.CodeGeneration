using QuestionnaireInvestigation.Questions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace ABPCodeGeneration.Generators
{
    public abstract class AbsGenerator : IGenerator
    {
        public (string Namespace, string Name) ClassInfo { get; set; }
        public abstract string GetTemplet();

        public abstract string GetPath();
        public abstract string GetDir();
        public string GetBasePath()
        {
            return $@"D:\360Downloads\QuestionnaireInvestigation (1)\src";
        }

        public List<(string Namespace, string Name)> GetClasses()
        {
            var s = GetClassInfo();
            var a = typeof(Question);
            return new List<(string Namespace, string Name)> { s, (a.Namespace, a.Name) };

        }

        private PropertyInfo[] GetPropertyInfoArray()
        {
            PropertyInfo[] props = null;
            try
            {
                Type type = typeof(Answer);
                object obj = Activator.CreateInstance(type);
                props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            }
            catch (Exception ex)
            { }
            return props;
        }
        private string[] ExcludePropertyes = new string[] { "LastModificationTime", "LastModifierId", "CreationTime", "CreatorId", "ExtraProperties", "ConcurrencyStamp", "Id" };
        public string GetPropertysTemplet() {
            var sb = new StringBuilder();
            var array = GetPropertyInfoArray();
            foreach (var item in array)
            {
                if (Array.IndexOf(ExcludePropertyes, item.Name)<0)
                {
                    sb.Append($"public {item.PropertyType.Name.ToLower()} {item.Name} {{ get; set; }}\r\n");

                }
            }
            return sb.ToString();
        }
        public (string Namespace, string Name) GetClassInfo()
        {
            var a = typeof(Answer);
            return (a.Namespace, a.Name);
        }
        private string CreateFile()
        {
            var path = GetPath();
            if (!File.Exists(path))
            {
                var dir = GetDir();
                Directory.CreateDirectory(dir);
                using (StreamWriter sw =new StreamWriter(path))
                {
                    var s = GetTemplet();
                    sw.WriteLine(s);
                }
            }

            return "";
        }

        public void Do()
        {
            foreach (var item in GetClasses())
            {
                ClassInfo = item;
                CreateFile();
            }
        }
    }
}
