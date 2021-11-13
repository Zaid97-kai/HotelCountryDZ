using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Hotel
    {
        public string NameHotel;
        public int Stars;
        public string description;
        public Country location;
        public static List<Hotel> HotelsList = new List<Hotel>();
        public Hotel(string Name, int NumStar, string Description, Country Location)
        {
            NameHotel = Name;
            Stars = NumStar;
            description = Description;
            location = Location;

        }

        public void Second(List<Hotel> HotelsList, List<Country> CountrysList)
        {
            Country selectedcountry = null;
            Hotel hotel = new Hotel();
            Console.Write("Введите название отеля: ");
            hotel.NameHotel = Console.ReadLine();
            Console.Write("Введите количество звезд: ");
            hotel.Stars = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите краткое описание: ");
            hotel.description = Console.ReadLine();
            Console.Write("Введите страну, где находится отель: ");
            string location = Console.ReadLine();
            foreach (Country c in CountrysList)
            {
                if (location == c.name)
                {
                    selectedcountry = c;
                    break;
                }
                if (selectedcountry == null)
                    return;
            }
            HotelsList.Add(new Hotel() { NameHotel = hotel.NameHotel, Stars = hotel.Stars, description = hotel.description, location = selectedcountry });

        }
        public void Third()
        {
            foreach (Hotel c in HotelsList)
            {
                Console.Write(c.NameHotel + " ");
                Console.Write(c.Stars + " ");
                Console.Write(c.description);
                Console.WriteLine("");
            }
        }
        public Hotel() { }


    }


    class Country
    {
        public string name;
        public string stol;
        public static List<Country> CountrysList = new List<Country>();
        public Country(string Name, string Stol)
        {
            name = Name;
            stol = Stol;
        }
        public void First()
        {
            Country country = new Country();
            Console.Write("Введите название страны: ");
            country.name = Console.ReadLine();
            Console.Write("Введите название столицы: ");
            country.stol = Console.ReadLine();
            CountrysList.Add(new Country() { name = country.name, stol = country.stol });
        }
        public void Fouth()
        {
            foreach (Country c in CountrysList)
            {
                Console.Write(c.name + " ");
                Console.Write(c.stol);
                Console.WriteLine("");
            }
        }
        public Country() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            Country country = new Country();
            int N = 0;
            while (N != 5)
            {
                Console.WriteLine("Выберите действие");
                Console.WriteLine("1) Добавление страны");
                Console.WriteLine("2) Добавление отеля");
                Console.WriteLine("3) Вывод всех отелей");
                Console.WriteLine("4) Вывод всех стран");
                Console.WriteLine("5) Выход из программы");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        country.First();
                        continue;
                    case 2:
                        hotel.Second(Hotel.HotelsList, Country.CountrysList);
                        continue;
                    case 3:
                        hotel.Third();
                        continue;
                    case 4:
                        country.Fouth();
                        continue;
                    case 5:
                        N = 5;
                        break;
                    default:
                        Console.WriteLine("Выберете что-то из предложенного списка");
                        break;
                }
            }
        }
    }
}
