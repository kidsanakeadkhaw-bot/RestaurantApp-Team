using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp_Team
{
    class Restaurant
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }
    }

    internal class Program
    {
        static List<Restaurant> restaurants = new List<Restaurant>
    {
        new Restaurant { Name = "KFC", Type = "Fast Food", Rating = 4.2 },
        new Restaurant { Name = "Tee Noi", Type = "Suki", Rating = 4.9 },
        new Restaurant { Name = "Starbuck", Type = "Drink", Rating = 4.7 },
        new Restaurant { Name = "Amazon", Type = "Drink", Rating = 4.5 },
        new Restaurant { Name = "Burgerking", Type = "Fast Food", Rating = 4.3 },
        new Restaurant { Name = "sushiro", Type = "Japanese", Rating = 4.5 }
    };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== Restaurant Menu =====");
                Console.WriteLine("1. Add Restaurant");
                Console.WriteLine("2. Show Good Rating");
                Console.WriteLine("3. Show Summary");
                Console.WriteLine("0. Exit");
                Console.Write("Select Menu: ");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        AddRestaurant();
                        break;
                    case "2":
                        ShowGoodRating();
                        break;
                    case "3":
                        ShowSummary();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid Menu");
                        break;
                }
            }
        }

        // คน A รับผิดชอบ
        static void AddRestaurant()
        {

            double rating;
            Console.WriteLine("กรอกชื่อร้านอาหาร :");
            string name = Console.ReadLine();
            Console.WriteLine("ประเภทร้านอหาร :");
            string type = Console.ReadLine();
            Console.WriteLine("คะแนนร้านอาหาร :");
            rating = double.Parse(Console.ReadLine());
            restaurants.Add(new Restaurant
            {
                Name = name,
                Type = type,
                Rating = rating
            });
            foreach (var item in restaurants)
            { 
                Console.WriteLine("Name : "+ item.Name);
                Console.WriteLine("type : "+item.Type);
                Console.WriteLine("Rating : "+item.Rating);
            }
             
        }

        // คน B รับผิดชอบ
        static void ShowGoodRating()
        {
            Console.WriteLine("Not completed");
        }

        // คน C รับผิดชอบ
        static void ShowSummary()
        {
            Console.WriteLine("Not completed");
        }
    }

}
