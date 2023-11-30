using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork10_2_.Classes
{
    public class Аppointment
    {
        int membersNeed;
        Event e;

        public Аppointment(Event e)
        {
            this.e = e;
            membersNeed = e.countNeed;
        }

        public void Appoint()
        {
            
            List<Student> slackers = new List<Student>();
            foreach (Student s in Student.students)
            {
                bool temp = false;
                foreach (Event ev in s.lastEvents)
                {
                    if (Event.lastEvents.Contains(ev))
                    {
                        temp = true;
                    }
                }
                if (!temp)
                {
                    slackers.Add(s);
                }
            }
            while (membersNeed != 0)
            {
                Random rnd = new Random();
                Student s = slackers[rnd.Next(0, slackers.Count)];
                e.AddMember(s);
                membersNeed--;
                File.AppendAllText($"{e.name}.Txt", $"{s.name}: {s.grope}\n");
                Console.WriteLine($"{s.name} из группы {s.grope} был выбран в качестве участника на мероприятие {e.name}");
                Thread.Sleep(1000);
            }
        }
    }
}
