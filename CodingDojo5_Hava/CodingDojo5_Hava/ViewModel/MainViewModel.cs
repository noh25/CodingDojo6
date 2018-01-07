using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using System;
using System.Windows.Media.Imaging;

namespace CodingDojo5_Hava.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private ItemVM category;
        private RelayCommand<ItemVM> btnBuyClick;

        public ObservableCollection<ItemVM> Items { get; set; }
        public ObservableCollection<ItemVM> WishList { get; set; }

        public ItemVM Category
        {
            get { return category; }
            set { category = value;
                  RaisePropertyChanged();
            }
        }

        public RelayCommand<ItemVM> BtnBuyClick
        {
            get
            {
                return btnBuyClick;
            }
            set
            {
                btnBuyClick = value;
                RaisePropertyChanged();
            }
        }

        public MainViewModel()
        {
            WishList = new ObservableCollection<ItemVM>();

            BtnBuyClick = new RelayCommand<ItemVM>((p) => 
            {
                WishList.Add(p);
            }, (p) => { return true; });
            Items = new ObservableCollection<ItemVM>();
            GenerateDemoData();
        }

        private void GenerateDemoData()
        {
            //Lego
            Items.Add(new ItemVM("MY Lego", new BitmapImage(new Uri("Images/lego1.jpg", UriKind.Relative)), "-"));

            Items[Items.Count - 1].AddItem(
                new ItemVM("Lego 2", new BitmapImage(new Uri("Images/lego2.jpg", UriKind.Relative)), "5+"));
            Items[Items.Count - 1].AddItem(
                new ItemVM("Lego 3", new BitmapImage(new Uri("Images/lego3.jpg", UriKind.Relative)), "10+"));
            Items[Items.Count - 1].AddItem(
               new ItemVM("Lego 4", new BitmapImage(new Uri("Images/lego4.jpg", UriKind.Relative)), "5+"));
            //Playmobil
            Items.Add(new ItemVM("MY Playmobil", new BitmapImage(new Uri("Images/playmobil1.jpg", UriKind.Relative)), "-"));
            Items[Items.Count - 1].AddItem(
                new ItemVM("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Items[Items.Count - 1].AddItem(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            Items[Items.Count - 1].AddItem(
               new ItemVM("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Items[Items.Count - 1].AddItem(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            Items[Items.Count - 1].AddItem(
               new ItemVM("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Items[Items.Count - 1].AddItem(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            Items[Items.Count - 1].AddItem(
               new ItemVM("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Items[Items.Count - 1].AddItem(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            Items[Items.Count - 1].AddItem(
               new ItemVM("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Items[Items.Count - 1].AddItem(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
        }
    }
}