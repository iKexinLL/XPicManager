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
using Microsoft.Win32;


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
		
        void onClickOpenFile(object sender, RoutedEventArgs e)
		{
        	var openFileDialog = new OpenFileDialog();
        	openFileDialog.Title = "选择数据源文件";
        	openFileDialog.Filter = "gif文件|*.gif";
			if (openFileDialog.ShowDialog() == false)
            {
                return;
            }

			MessageBox.Show(openFileDialog.FileName);
		}
        
		void onClickOpenFolder(object sender, RoutedEventArgs e)
		{
           	using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
			{
           		if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
           		{
           			MessageBox.Show(dialog.SelectedPath);
           		}
			}
			
		}
    }
};