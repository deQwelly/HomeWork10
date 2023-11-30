using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10_2_.Classes
{
    public class Student
    {
        public readonly static List<Student> students = new List<Student>();
        public readonly string name;
        public readonly string grope;
        private bool participates = false;
        public readonly List<Event> lastEvents = new List<Event>();

        private Student(string name, string grope)
        {
            this.name = name;
            this.grope = grope;
            students.Add(this);
        }

        public static void AddStudens(string path)
        {
            string[] students = File.ReadAllLines(path);
            foreach (string s in students)
            {
                string[] student = s.Split('|');
                if (student.Length > 0)
                {
                    new Student(student[0].Trim(), student[1].Trim());
                }
            }
        }

        public void TakePartInEvent(Event e)
        {
            if (lastEvents.Count == 3)
            {
                lastEvents.Clear();
            }
            participates = true;
            lastEvents.Add(e);
            e.AddMember(this);
            File.AppendAllText($"{e.name}.Txt", $"{name}: {grope}\n");
            Console.WriteLine($"{name} из группы {grope} по собственному желанию принимает участие в {e.name}");
        }

        public override string ToString()
        {
            return $"{name} | {grope}";
        }
    }
}
