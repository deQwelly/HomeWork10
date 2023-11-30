using BankAccountLibruary;
using HomeWork10_1_.Classses;
using HouseBuildingLibruary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork10_1_
{
    internal class Program
    {
        delegate void SortBooks();
        static void Main(string[] args)
        {
            ///Упражнение 11.1
            Console.WriteLine("Упражнение 11.1: Создать новый класс, который будет являться фабрикой объектов класса банковский счет");

            BankAccount acc = new BankAccountFactory().CreateAccount();
            ulong acc2Num = new BankAccountFactory().CreateAccount(BankAccountType.current);
            BankAccount acc3 = new BankAccountFactory().CreateAccount();

            Console.WriteLine(acc2Num);
            Console.WriteLine(acc.Number);
            Console.WriteLine(acc3.Number);

            BankAccountFactory.CloseAccount(acc.Number);

            ///Упражнение 11.2
            Console.WriteLine("\nУпражнение 11.2: Подключить сборку к проекту и откомпилировать тестовый пример со сборкой");

            ///Домашнее задание 11.1
            Creator.CreateHouse(10,10, 10, 10);
            Creator.CreateHouse(20, 20, 20, 20);
            Creator.CreateHouse(30, 30, 30, 30);

            Creator.RemoveHouse(1);

            ///Домашнее задание 11.2
            Console.WriteLine("\nДомашнее задание 11.2: Подключить сборку к проекту и откомпилировать тестовый пример со сборкой");

            ///Упражнение 12.1
            Console.WriteLine("\nУпражнение 12.1: Для класса банковский счет переопределить операторы == и != для\r\n" +
                "сравнения информации в двух счетах. Переопределить метод Equals аналогично оператору\r\n" +
                "==, не забыть переопределить метод GetHashCode(). Переопределить метод ToString() для\r\nпечати информации о счете.");
            Console.WriteLine(acc.Equals(acc2Num));
            Console.WriteLine(acc == acc3);
            Console.WriteLine(acc != acc3);
            Console.WriteLine(acc.Equals(acc));
            Console.WriteLine(acc == acc);
            Console.WriteLine(acc3.ToString());

            ///Упражнение 12.2
            Console.WriteLine("\nУпражнение 12.2: Создать класс рациональных чисел");
            Rational num1 = new Rational(1, 2);
            Rational num2 = new Rational(2, 3);
            Rational num3 = new Rational(1, 1);

            Console.WriteLine(num1.Equals(0.5));
            Console.WriteLine(num1 != 0.5);
            Console.WriteLine(num1 == num1);
            Console.WriteLine(num1 < 1);
            Console.WriteLine(num1 < 0.5);
            Console.WriteLine(num1 > 0.5);
            Console.WriteLine(num1 <= 0.5);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num3 + num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine((decimal)num1);
            Console.WriteLine((int)num3);

            ///Домашнее задание 12.1
            Console.WriteLine("\nДомашнее задание 12.1: Описать класс комплексных чисел. Реализовать операцию сложения, \n" +
                "умножения, вычитания, проверку на равенство двух комплексных чисел.");
            Complex cnum1 = new Complex(1, 2);
            Complex cnum2 = new Complex(1, 0);
            Complex cnum3 = new Complex(3, 4);

            Console.WriteLine(cnum1);
            Console.WriteLine(cnum2);
            Console.WriteLine(cnum2.Equals(1));
            Console.WriteLine(cnum1.Equals(new Complex(1, 2)));
            Console.WriteLine(cnum1 + cnum3);
            Console.WriteLine(cnum1 / cnum3);
            Console.WriteLine(cnum1 + 1);
            Console.WriteLine(cnum1 * cnum3);

            ///Домашнее задание 12.2
            Console.WriteLine("\nДомашнее задание 12.2: Написать делегат, с помощью которого реализуется сортировка книг.");
            Book book1 = new Book("Атака Титанов", "Хадзиме Исаяма", "Bessatsu Shonen Magazine");
            Book book2 = new Book("Магическая Битва", "Геге Акутами", "Weekly Shōnen Jump");
            Book book3 = new Book("Сердца Пандоры", "Дзюн Мотидзуки", "GFantasy");

            SortBooks SortByName = new SortBooks(BookShelf.SortByName);
            SortBooks SortByAuthor = new SortBooks(BookShelf.SortByAuthor);
            SortBooks SortByPublisher = new SortBooks(BookShelf.SortByPublisher);

            SortByName();
            //BookShelf.ShowShelf();

            SortByAuthor();
            //BookShelf.ShowShelf();

            SortByPublisher();
            BookShelf.ShowShelf();
        }
    }
}
