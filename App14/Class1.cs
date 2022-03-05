using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App14
{
    public enum Categorie
    {
        Food,
        Appliance
    }

        public class Product
    {
        public string Name { get; set; } 
        public int Price { get; set; }
        public string Image { get; set; }
        public Categorie Categorie { get; set; }
    }
}
