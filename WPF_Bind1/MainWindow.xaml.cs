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

namespace WPF_Bind1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //public CustomBindingSource BindingSource = new CustomBindingSource();
        public MainWindow()
        {

            //BindingSource.Source = "11222333";

            InitializeComponent();

            this.Title = "1.Binding from static variable";

            /*
            var stud = new Student() { age = 28, id = 2, name = "szp" };
            this.grid1.DataContext = BindingSource;
            //BindingOperations.SetBinding(this.lbl2, Label.DataContextProperty, new Binding() { new });
             * */
        }
    }
}
