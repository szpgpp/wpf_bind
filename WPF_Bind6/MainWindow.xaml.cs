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
using System.Xml;

namespace WPF_Bind6
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Title = "ListView ItemSource from XmlDataProvider";

            XmlDocument doc = new XmlDocument();
            doc.Load(Environment.CurrentDirectory+@"/data.xml");
            //通过XmlDataProvider进行绑定数据
            XmlDataProvider dp = new XmlDataProvider();
            dp.Document = doc;
            dp.XPath = @"StudentList/Student";
            this.listView1.SetBinding(ListView.ItemsSourceProperty, new Binding() { Source = dp });
        }
    }
}
