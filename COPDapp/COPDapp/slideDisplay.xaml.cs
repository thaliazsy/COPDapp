using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace COPDapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class slideDisplay : ContentPage
    {
        string currentItem;
        int currentItemPosition;

        public slideDisplay(String[] text)
        {
            InitializeComponent();
            carouselPPT.ItemsSource = text;
        }

        private void ItemChanged(object sender, CurrentItemChangedEventArgs e)     //連到主頁面
        {
            currentItem = e.CurrentItem.ToString();
        }

        private void PositionChanged(object sender, PositionChangedEventArgs e)		//連到主頁面
        {
            currentItemPosition = e.CurrentPosition;
            currentItemPositionLabel.Text = $"{currentItemPosition}";
        }

        private void Home_Activated(object sender, EventArgs e)		//連到主頁面
        {
            while (Navigation.ModalStack.Count > 0)
            {
                Navigation.PopModalAsync();
            }
        }
    }
}