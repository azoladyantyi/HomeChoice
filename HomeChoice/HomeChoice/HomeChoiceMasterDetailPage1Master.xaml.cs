using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeChoice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeChoiceMasterDetailPage1Master : ContentPage
    {
        public ListView ListView;

        public HomeChoiceMasterDetailPage1Master()
        {
            InitializeComponent();

            BindingContext = new HomeChoiceMasterDetailPage1MasterViewModel();
            ListView = MenuItemsListView;
        }

        class HomeChoiceMasterDetailPage1MasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<HomeChoiceMasterDetailPage1MasterMenuItem> MenuItems { get; set; }

            public HomeChoiceMasterDetailPage1MasterViewModel()
            {
                MenuItems = new ObservableCollection<HomeChoiceMasterDetailPage1MasterMenuItem>(new[]
                {
                    new HomeChoiceMasterDetailPage1MasterMenuItem { Id = 0, Title = "Explore" },
                    new HomeChoiceMasterDetailPage1MasterMenuItem { Id = 1, Title = "Shop" },
                    new HomeChoiceMasterDetailPage1MasterMenuItem { Id = 2, Title = "My Order" },
                    new HomeChoiceMasterDetailPage1MasterMenuItem { Id = 3, Title = "My Wish List" },
                    new HomeChoiceMasterDetailPage1MasterMenuItem { Id = 4, Title = "Scan" },
                    new HomeChoiceMasterDetailPage1MasterMenuItem { Id = 5, Title = "Mr Price Money" },
                    new HomeChoiceMasterDetailPage1MasterMenuItem { Id = 6, Title = "My Profile" },
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