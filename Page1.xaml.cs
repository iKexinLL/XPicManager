/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 05/17/2019
 * 时间: 11:19
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace XPicManager
{
	/// <summary>
	/// Interaction logic for Page1.xaml
	/// </summary>
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}
		
		void BackToMain(object sender, RoutedEventArgs e)
		{
			// 报错: System.InvalidOperationException: 无法导航，因为日志的 Back 堆栈中没有条目。
//			NavigationService.GetNavigationService(this).GoForward();
			
			// 报错: System.InvalidOperationException: 对于导航，“XPicManager.MainWindow”根元素无效。
//			NavigationService.GetNavigationService(this).Navigate(new Uri("MainWindow.xaml", UriKind.Relative));
			
			var mw = new MainWindow();
			
			mw.ShowDialog();
		}
	}
}