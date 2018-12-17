using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDogShop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User> {
                    new User()
                {
                        Login="anuar.temirbolat",
                        Password="Asd"
                },
                    new User
                    {
                        Login="OlegSkidan",
                        Password="123asd"
                    }
                };

           
            
            using (HotDogContext db=new HotDogContext())
            {
                db.Users.AddRange(users);
              
                List<Cook> cooks = new List<Cook>
            {
                new Cook
                {
                    FullName="Адильбек Хангой"
                },
                new Cook
                {
                    FullName="Райымбек Райымбек"
                }
            };
                db.Cooks.AddRange(cooks);

                List<Product> products = new List<Product>
            {
                new Product
                {                    
                    Name="Торт",
                    Price=1300,
                    Cook=cooks[0],
                    User=users[0]
                },
                new Product
                {                  
                    Name="Пицца",
                    Price=1500,
                    Cook=cooks[0],
                   User=users[1]
                },
                new Product
                {
                   
                    Name="Хот Дог",
                    Price=140,
                    Cook=cooks[1],
                  User=users[1]
                }
            };
                db.Products.AddRange(products);
                db.SaveChanges();
            }
        }
    }
}
