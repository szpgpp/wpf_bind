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

namespace WPF_Bind4
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Student myStudent = new Student { Age = 23, Id = 1, Name = "wxj" };
        public MainWindow()
        {
            InitializeComponent();

            this.Title = "4.Binding from common object";

            //var x = new Student { Age = 23, Id = 1, Name = "szp" };
            //this.grid1.DataContext = x ;
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
    }
}
