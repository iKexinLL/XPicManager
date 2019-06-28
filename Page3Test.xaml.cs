using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XPicManager
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            // var a = 1;
            // var b = 2;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // NavigationService.GetNavigationService(this).Navigate(new Page1());
            var p1 = new Page1();
            p1.MinHeight = this.Height + 500;
            p1.MinWidth = this.Width + 500;
            this.Content = p1;
        }
    }
}
