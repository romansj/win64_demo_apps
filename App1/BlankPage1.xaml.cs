using ClassLibraryNETSt;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace UWP{
    public sealed partial class BlankPage1 : Page{
        private ObservableCollection<ExamplePair> obsCollection = new ObservableCollection<ExamplePair>();

        public BlankPage1() {
            this.InitializeComponent();

            MyDataGrid.ItemsSource = obsCollection;


            var randomGenerator = new RandomGenerator("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 ");
            for (int i = 0; i < 100; i++) {
                var title = randomGenerator.getRandomString(5, 20);
                var descr = randomGenerator.getRandomString(5, 20);
                obsCollection.Add(new ExamplePair(title, descr));
            }
        }


        private async void ListView_ItemClick(object sender, ItemClickEventArgs e) {
            ContentDialog dialog = new ContentDialog();
            dialog.Title = "Save your work?";
            dialog.PrimaryButtonText = "Save";
            dialog.SecondaryButtonText = "Don't Save";
            dialog.CloseButtonText = "Cancel";
            dialog.DefaultButton = ContentDialogButton.Primary;

            var result = await dialog.ShowAsync();

        }
    }
}