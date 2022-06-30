using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppLessonWPF14
{
    public enum ProductTypes
    {
        Food,
        Applinces
    }

    public class Product
    {
        public string ProguctName { get; set; }
        public int ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public ProductTypes ProductType { get; set; }
    }
}
