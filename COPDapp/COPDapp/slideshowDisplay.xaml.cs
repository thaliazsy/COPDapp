using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace COPDapp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class slideshowDisplay : ContentPage
	{
		public slideshowDisplay (String[] imgsrc)
		{
			InitializeComponent ();
            carouselPPT.ItemsSource = imgsrc;		//設定 CarouselView的資料來源
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