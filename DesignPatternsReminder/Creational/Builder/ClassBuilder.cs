using System.Text;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class CodeBuilder
    {
        public List<string> MyClass = new List<string>();

        public StringBuilder stringBuilder = new StringBuilder();

        public CodeBuilder(string className)
        {
            MyClass.Add("public class ");
            MyClass.Add(className);
            MyClass.Add("\n{\n");
            MyClass.Add("}");
        }

        public CodeBuilder AddField(string fieldName, string fieldType)
        {
            MyClass.RemoveAt(MyClass.Count - 1);
            MyClass.Add($"  public {fieldType} {fieldName};\n");
            MyClass.Add("}");
            return this;
        }

        public override string ToString()
        {
            string elems = "";
            foreach (var elem in MyClass)
            {
                elems += elem;
            }

            return elems;
        }
    }

    //public static class Program
    //{

    //    public static void Main(string[] args)
    //    {
    //        var cb = new CodeBuilder("Person")
    //            .AddField("Name", "string")
    //            .AddField("Age", "int");
    //        Console.WriteLine(cb);
    //    }
    //}
}
