﻿using MusicPickerApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using MusicPickerApp.Api;

namespace MusicPickerApp
{
    public partial class App : Application
    {
        /// <summary>
        /// Main Class of the App
        /// At launch the app checks if a bearer is already located in the App's properties or not. If it is then it means that the user already logged successfully
        /// on a account on the app so he doesn't need to log in again every time he launches the App.
        /// </summary>
        public App()
        {
            // The root page of your application
            InitializeComponent();
            NavigationPage rootPage;
            if (Properties.ContainsKey("bearer")) {
                ApiClient.Instance.ProvideBearer(App.Current.Properties["bearer"] as string);
                rootPage = new NavigationPage((new DevicesListPage()));
            } else {
                
                rootPage = new NavigationPage(new LoginPage());
            }
           
            //ToolBar Color For Android
            rootPage.BarBackgroundColor = Color.FromHex("#387C13");
            MainPage = rootPage;
            App.Navigation = rootPage.Navigation;
            
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
            //stores the bearer
            App.Current.Properties["bearer"] = ApiClient.Instance.RetrieveBearer();
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            //provide the bearer to the api
             ApiClient.Instance.ProvideBearer(App.Current.Properties["bearer"] as string);
        }
    }
}
