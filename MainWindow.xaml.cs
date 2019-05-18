using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
    	public NavigationService naviService;
    	
        public MainWindow()
        {
            InitializeComponent();
            naviService = this.frmMain.NavigationService;
        }
		
        // 使用Ookii.Dialogs.Wpf打开文件的话,第一次会有些慢
        void onClickOpenFile(object sender, RoutedEventArgs e)
		{
//        	NavigationService.GetNavigationService(this).Navigate(new Uri("/Page1.xaml", UriKind.Relative));
        	var openFileDialog = new VistaOpenFileDialog();
        	openFileDialog.Title = "选择数据源文件";
        	openFileDialog.Filter = "gif文件|*.gif";
        	if ((bool)openFileDialog.ShowDialog(this))
        	{
				MessageBox.Show(openFileDialog.FileName);
				naviService.Navigate(new Uri("Page1.xaml", UriKind.Relative));
//				NavigationService.GetNavigationService(this).Navigate(new Page1());
//				this.frmMain.Navigate(new Uri("Page1.xaml", UriKind.Relative));
//				var pe = new Page1();
//				this.Content = pe.Content;
        	}
		}
        
		void onClickOpenFolder(object sender, RoutedEventArgs e)
		{
			// https://stackoverflow.com/questions/1922204/open-directory-dialog
			var tp = new VistaFolderBrowserDialog();
			if ((bool)tp.ShowDialog(this))
			{
				SearchPics(tp.SelectedPath);
			}
		}
		
		
		
		void SearchPics(string path)
		{
			
			var files = Directory.EnumerateFiles(path, "*.*", SearchOption.TopDirectoryOnly)
				.Where(s => s.EndsWith(".gif", StringComparison.OrdinalIgnoreCase) 
				       	|| s.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) 
				       	|| s.EndsWith(".png", StringComparison.OrdinalIgnoreCase));
			#if (DEBUG) 
			foreach (var i in files)
			{
				Debug.WriteLine(i);
			}
			#endif
		}
		void onClickTest(object sender, RoutedEventArgs e)
		{
	        NavigationService nav = NavigationService.GetNavigationService(this);
	        nav.Navigate(new Uri("Page2.xaml", UriKind.RelativeOrAbsolute));			
		}
    }
}
