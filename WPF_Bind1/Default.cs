using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_Bind1
{
    public static class Default
    {
        public static String Number = "1234567890 1234567890 1234567890 1234567890";
    }
    /*
    public class CustomBindingSource : DependencyObject
    {
        public string Source
        {
            get { return (String)this.GetValue(SourceProperty); }
            set { this.SetValue(SourceProperty, value); }
        }
        public static readonly DependencyProperty SourceProperty
            = DependencyProperty.Register("Source", typeof(String)
            , typeof(CustomBindingSource)
            , new FrameworkPropertyMetadata("DefaultValue"));
    }
     * */
}
