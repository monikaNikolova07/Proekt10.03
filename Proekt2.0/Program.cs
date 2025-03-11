using Proekt2._0.Models;
using System.Globalization;
using System.Numerics;

namespace Proekt2._0
{
   
    public class Program
    { 
        public static List <Theaters> theatersL = new List<Theaters>();
        public static List<Actors> actorsL = new List<Actors>();
        public static List<Playes> playesL = new List<Playes>();
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Menu();
                Console.WriteLine("Изберете опция:");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTheater();
                        break;
                    case "2":
                        AddActor();
                        break;
                    case "3":
                        AddPlay();
                        break;
                    case "4":
                        AddProprietary();
                        break;
                    case "5":
                        PrintActors();
                        break;
                    case "6":
                        PrintTheaters();
                        break;
                    case "7":
                        PrintPlays();
                        break;
                    case "8":
                        UpdatePlayTitle();
                        break;
                    default:
                        Console.WriteLine("Невалиден избор, опитайте отново.");
                        break;
                }
            }
        }

        public static void Menu()
        {
            Console.WriteLine("Добре дошли в Тетър Онлайн");
            Console.WriteLine("1.Add Theater");
            Console.WriteLine("2.Add Actor");
            Console.WriteLine("3.Add Play");
            Console.WriteLine("4.Add Proprietary");
            Console.WriteLine("5.Принтирай всички актьори");
            Console.WriteLine("6.Принтитай всички театри:");
            Console.WriteLine("7.Принтирай всички Представления:");
            Console.WriteLine("8.Актуализирай името на пиесата:");
        }

        static void AddTheater()
        {
            Console.WriteLine("Ваведете име на татъра:");
            string name = Console.ReadLine();
            Console.WriteLine("Ваведете година в която е създаден театъра:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Ваведете населено място в което се намира театъра:");
            string city = Console.ReadLine();
            Theaters theaters = new Theaters(name, year, city);
            theatersL.Add(theaters);
        }

        static void AddActor()
        {
            Console.WriteLine("Ваведете първо име на актьора:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Ваведете второ име на актьора:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Ваведете града в който живее на актьора:");
            string city = Console.ReadLine();
            Actors actors = new Actors(firstName, lastName, city);
            actorsL.Add(actors);
        }

        static void AddPlay()
        {
            Console.WriteLine("Ваведете заглавие на пиесата:");
            string title = Console.ReadLine();
            Console.WriteLine("Ваведете година в която е написана пиесата:");
            int years = int.Parse(Console.ReadLine());
            Playes playes = new Playes(title, years);
            playesL.Add(playes);
        }

        static void AddProprietary()
        {
            Console.WriteLine("Ваведете необходими дрехи:");
            string clought = Console.ReadLine();
            Console.WriteLine("Ваведете необходими предмети:");
            string subjects = Console.ReadLine();
            Console.WriteLine("Ваведете неоходимата електроника:");
            string electronics = Console.ReadLine();
            Proprietary proprietary = new Proprietary(clought, subjects, electronics);
        }

        static void PrintActors()
        {
            Console.WriteLine("Списък с актьори:");
            foreach (var actor in actorsL)
            {
                Console.WriteLine($"{actor.FirstName} {actor.LastName} - {actor.City}");
            }
        }

        static void PrintTheaters()
        {
            Console.WriteLine("Списък с театри:");
            foreach (var theater in theatersL)
            {
                Console.WriteLine($"{theater.Name} ({theater.Year}) - {theater.City}");
            }
        }

        static void PrintPlays()
        {
            Console.WriteLine("Списък с пиеси:");
            foreach (var play in playesL)
            {
                Console.WriteLine($"{play.Title} ({play.Years})");
            }
        }

        static void UpdatePlayTitle()
        {
            Console.Write("Въведете старото име на пиесата: ");
            string oldTitle = Console.ReadLine();
            Playes play = playesL.Find(p => p.Title == oldTitle);

            if (play != null)
            {
                Console.Write("Въведете новото име: ");
                play.Title = Console.ReadLine();
                Console.WriteLine("Заглавието е актуализирано!");
            }
            else
            {
                Console.WriteLine("Пиесата не е намерена!");
            }
        }
    }
}
