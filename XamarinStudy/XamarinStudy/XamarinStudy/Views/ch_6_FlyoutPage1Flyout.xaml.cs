﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinStudy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ch_6_FlyoutPage1Flyout : ContentPage
    {
        public ListView ListView;

        public ch_6_FlyoutPage1Flyout()
        {
            InitializeComponent();

            BindingContext = new ch_6_FlyoutPage1FlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class ch_6_FlyoutPage1FlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ch_6_FlyoutPage1FlyoutMenuItem> MenuItems { get; set; }

            public ch_6_FlyoutPage1FlyoutViewModel()
            {
                MenuItems = new ObservableCollection<ch_6_FlyoutPage1FlyoutMenuItem>(new[]
                {
                    new ch_6_FlyoutPage1FlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new ch_6_FlyoutPage1FlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new ch_6_FlyoutPage1FlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new ch_6_FlyoutPage1FlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new ch_6_FlyoutPage1FlyoutMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}