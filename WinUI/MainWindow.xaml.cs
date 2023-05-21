// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using ClassLibraryNETSt;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private ObservableCollection<ExamplePair> obsCollection = new ObservableCollection<ExamplePair>();

        public MainWindow()
        {
            InitializeComponent();

            var randomGenerator = new RandomGenerator("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 ");
            for (int i = 0; i < 100; i++)
            {
                var title = randomGenerator.getRandomString(5, 20);
                var descr = randomGenerator.getRandomString(5, 20);
                obsCollection.Add(new ExamplePair(title, descr));
            }
        }


        private async void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            // value outside expected range.........

            ContentDialog dialog = new ContentDialog(); 
            //MyContentDialog dialog = new MyContentDialog(); // buttons are not styled roundedly and looks a bit out of place style wise
            dialog.Title = "Save your work?";
            dialog.PrimaryButtonText = "Save";
            dialog.SecondaryButtonText = "Don't Save";
            dialog.CloseButtonText = "Cancel";
            dialog.DefaultButton = ContentDialogButton.Primary;
            dialog.XamlRoot = this.Content.XamlRoot;


            var result = await dialog.ShowAsync();

        }


    }
}
