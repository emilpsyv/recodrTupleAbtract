using System.Threading.Channels;

namespace recordTouple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------record-----------------------------");
            #region Record
            StudentRecord std1 = new StudentRecord()
            {
                Name = "Emil",
                Surname = "pasayev",
                Group = "641R",
                Age = 19

            };
            StudentRecord std2 = std1 with { Name = "akula", Surname = "lakuka" };
            
            Console.WriteLine(std1);
            Console.WriteLine(std2);
            //StudentRecord std2 = new StudentRecord("A", "B");
            Console.WriteLine(Object.ReferenceEquals(std1, std2));
            Console.WriteLine(std1 == std2);
            #endregion
            Console.WriteLine("_________________________tuple_______________________________");

            (string, int) result1 = ("birinci", 2);
            Console.WriteLine(result1);

            (int , string ,int) result2=(1132,"aslam",3);
            
            Console.WriteLine(result2);


            (string, int, int, int, string, string) result3 = ("sakan", 213, 231, 3, "kriminal", "nany");
            Console.WriteLine(result3);

            //var result = Bo();
            (int age, string name) result = Bo();
            result.age = 32;
            result.name = "agasi";

            
            Console.WriteLine(result);

        }
       static (int,string) Bo()
        {
            return (13, "dada");
        }

       
    }
    record StudentRecord(string Name = "studetN", string Surname = "studentS", int Age = 16, string Group = "", string Uni = "aztu");

}
    

