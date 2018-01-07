using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CodingDojo5_Hava.ViewModel
{
    public class ItemVM : ViewModelBase
    {
        public string Description { get; set; }

        public BitmapImage ItemImage { get; set; }

        public string AgeRecommendation { get; set; }

        public ObservableCollection<ItemVM> Items { get; set; }

        public ItemVM(string description, BitmapImage itemImage, string ageRecommendation)
        {
            Description = description;
            ItemImage = itemImage;
            AgeRecommendation = ageRecommendation;
        }

        public int NoOfParts
        {
            get
            {
                if (Items != null)
                {
                    return Items.Count;
                }
                else return 0;
            }
        }

        public void AddItem(ItemVM item)
        {
            if (Items == null)
            {
                Items = new ObservableCollection<ItemVM>();
            }
            Items.Add(item);
        }
    }
}
