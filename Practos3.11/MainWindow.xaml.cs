using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
using static Practos3._11.Class1;

namespace Practos3._11
{

    

    public partial class MainWindow : Window
    {
        private yandex_storeEntities1 context = new yandex_storeEntities1();
        List<Class11> class1 = new List<Class11>();
        List<Class2> class2s = new List<Class2>();
        
     
        public MainWindow()
        {
            InitializeComponent();

            foreach (var items in context.Delivery.ToList())
            {
                
                class1.Add(new Class11(items));
            }
            foreach (var items in context.Order_Products.ToList())
            {
                class2s.Add(new Class2(items));
            }



            wasd.ItemsSource = class1;
            ter.ItemsSource = class2s;

        
        }
    }
}
