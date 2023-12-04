﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Locall
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Maakonnad : ContentPage
    {
        bool edited = true; //флаг редактирования
        public Maakond Maakond { get; set; }
        public Maakonnad(Maakond maakond)
        {
            InitializeComponent();

            Maakond = maakond;
            if(maakond == null)
            {
                Maakond = new Maakond();
                edited = false;
            }
            this.BindingContext = Maakond;
        }
        public async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

            if(edited == false) 
            {
                //находим в стеке предпоследнюю страницу - то есть MainPage
                NavigationPage navPage = (NavigationPage)Application.Current.MainPage;
                IReadOnlyList<Page> navStack = navPage.Navigation.NavigationStack;
                MainPage homePage = navStack[navPage.Navigation.NavigationStack.Count - 1] as MainPage;
                if (homePage != null)
                {
                    homePage.AddMaakond(Maakond);
                }
            }
        }
    }
}