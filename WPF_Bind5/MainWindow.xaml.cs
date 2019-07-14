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

namespace WPF_Bind5
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Title = "5.ItemDataSource from List";

            IList<Student> list = new List<Student>()
            {
                new Student(){ID=1,Name="狗娃"},
                new Student(){ID=2,Name="狗剩"},
                new Student(){ID=3,Name="铁蛋"}
            };
            this.listView1.ItemsSource = list;
        }
    }
    public class Student 
    {
        public int ID { get; set; }
        public String Name { get; set; }
    }
}
