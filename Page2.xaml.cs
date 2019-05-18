/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2019/5/18
 * 时间: 15:41
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace XPicManager
{
	/// <summary>
	/// Interaction logic for Page2.xaml
	/// </summary>
	public partial class Page2 : Page
	{
		public Page2()
		{
			InitializeComponent();
		}
		void Button_Click(object sender, RoutedEventArgs e)
		{
	        NavigationService nav = NavigationService.GetNavigationService(this);
	        nav.Navigate(new Uri("Page1.xaml", UriKind.RelativeOrAbsolute));			
		}
	}
}