using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppLessonWPF14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            { 
                ProguctName = "Холодильник",
                ProductPrice = 90000,
                ProductImage = "Data/холодильник.webp",
                ProductType = ProductTypes.Appliances
            });
            products.Add(new Product()
            { 
                ProguctName = "Молоко",
                ProductPrice = 50,
                ProductImage = "Data/Молоко.webp",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            { 
                ProguctName = "Мясо",
                ProductPrice = 300,
                ProductImage = "Data/Мясо.webp",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            { 
                ProguctName = "Кофеварка",
                ProductPrice = 7000,
                ProductImage = "Data/Кофеварка.webp",
                ProductType = ProductTypes.Appliances
            });
            products.Add(new Product()
            { 
                ProguctName = "Сервиз",
                ProductPrice = 12000,
                ProductImage = "Data/сервиз.jpg",
                ProductType = ProductTypes.Appliances
            });
            LstBox.ItemsSource = products;
        }
    }
}
