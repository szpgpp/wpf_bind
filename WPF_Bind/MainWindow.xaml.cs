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

namespace WPF_Bind
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Title = "0.Binding from UI element";

            //BindingOperations.SetBinding(this.txt2_d, TextBox.TextProperty, new Binding() { Source = this.txt2, Path = new PropertyPath("Text") });
            
            Binding bd = new Binding();
            bd.Source = txt2;
            bd.Path = new PropertyPath("Text");
            
            //txt2_d.SetBinding(TextBox.TextProperty, bd);
            BindingOperations.SetBinding(this.txt2_d, TextBox.TextProperty, bd);
        }
    }
}
