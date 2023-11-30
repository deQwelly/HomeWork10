using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10_2_.Classes
{
    public class Event
    {
        public readonly static List<Event> lastEvents = new List<Event>();
        public readonly string name;
        public readonly DateTime date;
        public readonly int countMember;
        public int countNeed;
        private List<Student> students = new List<Student>();
        public Event(string name, DateTime date, int countMember)
        {
            this.name = name;
            this.date = date;
            this.countMember = countMember;
            countNeed = countMember;

            if (lastEvents.Count == 3)
            {
                lastEvents.Clear();
            }
            lastEvents.Add(this);

            File.AppendAllText($"{name}.Txt", $"Мероприятие: {name} на {date}\n");
            File.AppendAllText($"{name}.Txt", $"Нужно {countMember} человек. Провести розыгрыш, если необходимое количество людей соберется\n");
            File.AppendAllText($"{name}.Txt", $"Участники:\n");

            File.AppendAllText("AllEvents.Txt", $"{name}: дата розыгрыша: {date}\n");
        }

        public int CountNeed
        {
            get;
            private set;
        }

        public void AddMember(Student student)
        {
            if (students.Count < countMember)
            {
                students.Add(student);
                countNeed--;
            }
            else
            {
                Console.WriteLine($"Участники на мероприятие {name} уже набраны");
            }
        }

        
    }
}
