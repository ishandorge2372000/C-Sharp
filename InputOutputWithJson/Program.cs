using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using Newtonsoft.Json;

namespace InputOutputWithJson
{
    public class Program
    {
        private const string jsonFile = "Student.json";
        static void Main(string[] args)
        {
            //string studentData = ReadStudentData();
            //Console.WriteLine(studentData);
            var studentData = ReadStudentDataUsingDeserializer();
            ShowStudentData(studentData);
            Console.ReadLine();
        }

        public static string ReadStudentData()
        {
            string studentData = System.IO.File.ReadAllText(jsonFile);
            return studentData;
        }

        public static IList<Student> ReadStudentDataUsingDeserializer()
        {
            var studentData = System.IO.File.ReadAllText(jsonFile);
            return JsonConvert.DeserializeObject <IList<Student>>(studentData);
        }

        public static void ShowStudentData(IList<Student> studentData)
        {
            foreach (var student in studentData)
            {
                Console.WriteLine($"Student First Name : {student.firstName}\nStudent First Name : {student.lastName}\nAge : {student.age}\n\n");
            }
        }
    }
}
