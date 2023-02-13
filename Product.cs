using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    public class Product
    {
        public string Name;
        public decimal Cina;
        Product()
        {

        }
        public Product(string name, decimal cina)
        {
            this.Name = name;
            this.Cina = cina;
        }
        public override string ToString()
        {
            return $"{this.Name} - {this.Cina}";
        }
    }
}
