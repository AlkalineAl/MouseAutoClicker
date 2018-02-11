using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace MouseAutoClicker
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        internal ObservableCollection<Item> Items { get; private set; }

        public MainPage()
        {
            ApplicationViewTitleBar formattableTitleBar = ApplicationView.GetForCurrentView().TitleBar;
            formattableTitleBar.ButtonBackgroundColor = Colors.Transparent;
            formattableTitleBar.BackgroundColor = Colors.Transparent;
            formattableTitleBar.InactiveBackgroundColor = Colors.Transparent;
            formattableTitleBar.InactiveForegroundColor = Colors.Transparent;
            formattableTitleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
            formattableTitleBar.ButtonInactiveForegroundColor = Colors.Transparent;
            CoreApplicationViewTitleBar coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = true;

            
            this.InitializeComponent();


           
            
        }

        private void SlidableListItem_RightCommandRequested(object sender, EventArgs e)
        {

        }

        private void SlidableListItem_LeftCommandRequested(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Items = new ObservableCollection<Item>();
             for (var i = 0; i < 1000; i++)

            {
                lv.Items.Add(new Item() { Text = "Item " + i, Subject = "123" });

            }


            
        }

        private void SwipeItem_Invoked(SwipeItem sender, SwipeItemInvokedEventArgs args)
        {

        }

        private void SwipeItem_Invoked_1(SwipeItem sender, SwipeItemInvokedEventArgs args)
        {

        }

        private void SwipeItem_Invoked_2(SwipeItem sender, SwipeItemInvokedEventArgs args)
        {

        }
    }

    internal class Item
    {
        public Item()
        {
        }

        public string Subject { get; set; }
        public string Text { get; set; }

    }
}
