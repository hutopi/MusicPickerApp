﻿using MusicPickerApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace MusicPickerApp
{
    public partial class App : Application
    {
        public App()
        {
            // The root page of your application
            InitializeComponent();
            MainPage = new NavigationPage(new LoginPage());
            App.Navigation = MainPage.Navigation;
            
        }
        public static INavigation Navigation {
            get;
            set;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
