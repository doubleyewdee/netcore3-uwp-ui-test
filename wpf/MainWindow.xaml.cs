using Microsoft.Toolkit.Wpf.UI.XamlHost;
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

namespace test_uwp_netcore3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TabView_ChildChanged(object sender, EventArgs e)
        {
            var host = (WindowsXamlHost)sender;
            var tabView = (Microsoft.Toolkit.Uwp.UI.Controls.TabView)host.Child;
            if (tabView == null)
            {
                return;
            }

            tabView.Header = new Windows.UI.Xaml.Controls.TextBlock { Text = "A dumb header", FontSize = 16 };
            tabView.Items.Add(new Microsoft.Toolkit.Uwp.UI.Controls.TabViewItem { Header = "Tab 1", Content = new Windows.UI.Xaml.Controls.TextBlock { Text = "A tab? " } });
            tabView.Items.Add(new Microsoft.Toolkit.Uwp.UI.Controls.TabViewItem { Header = "Tab 1", Content = new Windows.UI.Xaml.Controls.TextBlock { Text = "Another tab? " } });
            //tabView.Items.Add(new Windows.UI.Xaml.Controls.TextBlock { Text = "A tab?" });
            //tabView.Items.Add(new Windows.UI.Xaml.Controls.TextBlock { Text = "Another tab?" });

            //tabView.Resources.Add(new KeyValuePair<object, object>("TabViewItemHeaderMinHeight", (double)40));
            //tabView.Resources.Add(new KeyValuePair<object, object>("TabViewItemHeaderMinWidth", (double)40));
            //tabView.Resources.Add(new KeyValuePair<object, object>("TabViewItemHeaderMaxWidth", (double)200));
            /*
                  <controls:TabView.Resources>
        <x:Double x:Key="TabViewItemHeaderMinHeight">40</x:Double>
        <x:Double x:Key="TabViewItemHeaderMinWidth">48</x:Double>
        <x:Double x:Key="TabViewItemHeaderMaxWidth">200</x:Double>
      </controls:TabView.Resources>
             */
        }
    }
}
