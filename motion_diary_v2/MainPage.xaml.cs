﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍


namespace motion_diary_v2
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary> 
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //public bool Navigate(Type sourcePageType,object parameter);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = new User
            {
                userName = nameInput.Text
            };

            this.Frame.Navigate(typeof(ChoosePhoto),user);
            //this.DataContext = nameInput;
            //this.NavigationService.Navigate(LogoPage,nameInput.Text);
        }
    }
}
