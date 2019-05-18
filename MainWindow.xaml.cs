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
using Ookii.Dialogs.Wpf;

namespace XPicManager
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
		
        // 使用Ookii.Dialogs.Wpf打开文件的话,第一次会有些慢
        void onClickOpenFile(object sender, RoutedEventArgs e)
		{
        	var openFileDialog = new VistaOpenFileDialog();
        	openFileDialog.Title = "选择数据源文件";
        	openFileDialog.Filter = "gif文件|*.gif";
        	if ((bool)openFileDialog.ShowDialog(this))
        	{
				MessageBox.Show(openFileDialog.FileName);
				NavigationService.GetNavigationService(this).Navigate(new Uri("Page1.xaml"));
        	}
		}
        
		void onClickOpenFolder(object sender, RoutedEventArgs e)
		{
			// https://stackoverflow.com/questions/1922204/open-directory-dialog
			var tp = new VistaFolderBrowserDialog();
			if ((bool)tp.ShowDialog(this))
				MessageBox.Show(tp.SelectedPath);
		}
    }
}
