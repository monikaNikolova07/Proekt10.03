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
            
        }

        public static void Menu()
        {
            Console.WriteLine("Добре дошли в Тетър Онлайн");
            Console.WriteLine("1.Add Theater");
            Console.WriteLine("2.Add Actor");
            Console.WriteLine("3.Add Play");
            Console.WriteLine("4.Add Proprietary");

            Console.WriteLine("5.Add Actor to Theater");
            Console.WriteLine("6.Add Actor to Play");

            Console.WriteLine("7 Принтирай всички актьори");
            Console.WriteLine("8 Принтитай всички театри:");
            Console.WriteLine("9 Принтирай всички Представления:");
            Console.WriteLine("10 Принтирай кой актьор в кой театър е:");
            Console.WriteLine("11 Провери дали съществува такъв театър:");
            Console.WriteLine("12 Провери дали съществува такъв актьор:");
            Console.WriteLine("13 Актуализирай името на пиесата:");
            Console.WriteLine("13 Намери пиесата по година:");
        }

        public void AddTheater()
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

        public void AddActor()
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

        public void AddPlay()
        {
            Console.WriteLine("Ваведете заглавие на пиесата:");
            string title = Console.ReadLine();
            Console.WriteLine("Ваведете година в която е написана пиесата:");
            int years = int.Parse(Console.ReadLine());
            Playes playes = new Playes(title, years);
            playesL.Add(playes);
        }

        public void AddProprietary()
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

        
    }
}
