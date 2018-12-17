using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDogShop
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }      
        public ICollection<Product> Products { get; set; }
        public User()
        {
            Products = new List<Product>();
        }
    }
}
