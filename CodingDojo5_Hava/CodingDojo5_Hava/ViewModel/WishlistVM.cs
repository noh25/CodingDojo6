using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo5_Hava.ViewModel
{
    public class WishlistVM : ViewModelBase
    {
        public ObservableCollection<ItemVM> Items { get; set; }

        Messenger messenger = SimpleIoc.Default.GetInstance<Messenger>();

        /*public WishListVM()
        {
            Items = new ObservableCollection<ItemVM>();
            //messenger.Register<PropertyChangedMessage<ItemVM>>(this, updateList);
        }*/
    }
}
