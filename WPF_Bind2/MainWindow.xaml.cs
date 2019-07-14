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

namespace WPF_Bind2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public CustomBindingSource BindingSource = new CustomBindingSource();
        public MainWindow()
        {
            this.BindingSource.Name = "szp";

            InitializeComponent();

            this.Title = "2.Binding from DependencyObject";

            this.grid1.DataContext = this.BindingSource;
        }
    }
    public class CustomBindingSource : DependencyObject
    {
        public string Name
        {
            get { return (String)this.GetValue(NameProperty); }
            set { this.SetValue(NameProperty, value); }
        }
        public static readonly DependencyProperty NameProperty
            = DependencyProperty.Register("Name", typeof(String)
            , typeof(CustomBindingSource)
            , new FrameworkPropertyMetadata("DefaultValue"));
    }
}
