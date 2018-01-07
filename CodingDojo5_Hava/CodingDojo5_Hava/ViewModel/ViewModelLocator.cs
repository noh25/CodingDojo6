/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:CodingDojo5_Hava"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace CodingDojo5_Hava.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
            //SimpleIoc.Default.Register<MyLegoVM>();
            //SimpleIoc.Default.Register<MyPlaymobilVM>();
            //SimpleIoc.Default.Register<WishlistVM>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        /*public MyLegoVM MyLego
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MyLegoVM>();
            }
        }

        public MyPlaymobilVM MyPlaymobil
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MyPlaymobilVM>();
            }
        }

        public WishlistVM Wishlist
        {
            get
            {
                return ServiceLocator.Current.GetInstance<WishlistVM>();
            }
        }*/

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}