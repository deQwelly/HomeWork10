using HomeWork10_2_.Classes;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork10_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool iter = true;
            Student.AddStudens("Students.Txt");
            Console.WriteLine("enter - создать мероприятие, esc - закрыть программу");
            while (iter)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.Write("\nВведите название мероприятия: ");
                    string name = Console.ReadLine();
                    if (name.Length > 0)
                    {
                        Console.Write("Обозначте дату мероприятия: (dd.mm.yyyy) ");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
                        {
                            Console.Write("Введите необходимое число участников: ");
                            if (int.TryParse(Console.ReadLine(), out int countMembers))
                            {
                                Event e = new Event(name, date, countMembers);
                                Random rnd = new Random();
                                Student.students[rnd.Next(0, Student.students.Count)].TakePartInEvent(e);
                                Thread.Sleep(1000);
                                new Аppointment(e).Appoint();
                            }
                            else
                            {
                                Console.WriteLine("Количество должно быть целым числом");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Введите дату правильно, как указано в примере");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Пустое имя");
                    }
                }

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    iter = false;
                }
            }
        }
    }
}
