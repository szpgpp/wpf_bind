using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WPF_Bind3
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public math mydata = new math();
        public MainWindow()
        {
            this.mydata.Input1 = 999;
            this.mydata.Input2 = 899;
            this.mydata.Result = 699;

            InitializeComponent();

            this.Title = "4.Binding from NotificationObject";

            this.grid1.DataContext = mydata;
        }
    }
    public class math : NotificationObject
    {
        private double input1;
        public double Input1
        {
            get { return input1; }
            set
            {
                input1 = value;
                this.RaisePropertyChanged("Input1");
            }
        }

        private double input2;
        public double Input2
        {
            get { return input2; }
            set
            {
                input2 = value;
                this.RaisePropertyChanged("Input2");
            }
        }

        private double result;
        public double Result
        {
            get { return result; }
            set
            {
                result = value;
                this.RaisePropertyChanged("Result");
            }
        }
    }

    public class NotificationObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
