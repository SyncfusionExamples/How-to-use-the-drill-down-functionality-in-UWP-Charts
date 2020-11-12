using Syncfusion.UI.Xaml.Charts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ChartDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Selection changed of chart 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chart_SelectionChanged(object sender, ChartSelectionChangedEventArgs e)
        {
            IList items = e.SelectedSeries.ItemsSource as IList;
            if (e.SelectedIndex != -1)
            {
                //Set the current window content from navigated page which is representing the chart with detailed
                Window.Current.Content = new SecondPage(items[e.SelectedIndex] as Model);

                //To get back to initial page, enable the back button with the help of SystemNavigationManager's AppViewBackButtonVisibility.
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;

                //Once back button click to view the entire automobile list then, it will keep the content of window as main page
                SystemNavigationManager.GetForCurrentView().BackRequested += (s, r) =>
                {
                    Window.Current.Content = new MainPage();
                    SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
                };
            }
        }
    }
}
