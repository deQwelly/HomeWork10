using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10_3_
{
    internal class Program
    {
        public static void DisplayMassage(string mes)
        {
            Console.WriteLine(mes);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Выберите одно из следующих событий");
            string[] evs = { "Новая глава манги", "Новый фильм Нолана", "Выход новой видеокарты", "Новая столовая рядом с унивром", "На пару принесли конфетки" };
            for (int i = 0; i < evs.Length; i++)
            {
                Console.WriteLine($"{i+1} - {evs[i]}");
            }
            Console.Write("Напишите номер понравившегося события: ");
            if (int.TryParse(Console.ReadLine(), out int ev))
            {
                if (ev > 0 || ev < (evs.Length + 1))
                {
                    Person p1 = new Person("Саша", "Новая глава манги");
                    Person p2 = new Person("Дима", "Новый фильм Нолана");
                    Person p3 = new Person("Ваня", "Новая столовая рядом с унивром");

                    p1.ReactionToEvent += DisplayMassage;
                    p2.ReactionToEvent += DisplayMassage;
                    p3.ReactionToEvent += DisplayMassage;

                    foreach (Person p in Person.all)
                    {
                        if (p.WhatAwaits == evs[ev])
                        {
                            p.React();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Указанное число не принадлежит номеру");
                }
            }
            else
            {
                Console.WriteLine("Некорректно введен номер");
            }
        }
    }
}
