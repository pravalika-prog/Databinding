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

namespace WpfApp1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class ListViewGridViewSample : Window
	{
		public ListViewGridViewSample()
		{
			InitializeComponent();
			List<User> items = new List<User>();
			items.Add(new User() { Name = "pravalika", Age = 42, Mail = "pravalika@gmail.com" });
			items.Add(new User() { Name = "mani", Age = 39, Mail = "mani@gmail.com" });
			items.Add(new User() { Name = "damodar", Age = 13, Mail = "damodar@gmail.com" });
			lvUsers.ItemsSource = items;
		}
	}

	public class User
	{
		public string Name { get; set; }

		public int Age { get; set; }

		public string Mail { get; set; }
	}
}

