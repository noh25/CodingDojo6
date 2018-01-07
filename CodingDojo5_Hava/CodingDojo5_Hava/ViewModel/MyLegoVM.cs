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
using System.Windows.Media;

namespace CodingDojo5_Hava.ViewModel
{
    public class MyLegoVM : ViewModelBase
    {
        public ObservableCollection<ItemVM> Items { get; set; }

        public RelayCommand BtnBuyClickCmd { get; set; }
        //Messenger messenger = SimpleIoc.Default.GetInstance<Messenger>();

        public MyLegoVM()
        {
            Items = new ObservableCollection<ItemVM>();
            //messenger.Register<PropertyChangedMessage<ItemVM>>(this, updateList);
        }


        //public static String NAME = "MY Lego";

        //public ImageSource LegoImage { get; set; }
    }
}
