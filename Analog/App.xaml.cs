﻿using Analog.ViewViewModels.Main;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Analog
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
