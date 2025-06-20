using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza_project
{
    public class PizzaOrder
    {
        public string Size { get; set; }
        public string Crust { get; set; }
        public string Place { get; set; }
        public List<string> Toppings { get; set; } = new List<string>();
        public double TotalPrice { get; set; }
    }
}
