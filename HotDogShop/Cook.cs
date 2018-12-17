using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDogShop
{
    public class Cook
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public ICollection<Product> Products { get; set; }
        public Cook()
        {
            Products = new List<Product>();
        }
    }
}
