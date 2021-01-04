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
            carouselPPT.ItemsSource = imgsrc;
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            foreach (Page page in Navigation.ModalStack)
            {
                Navigation.PopModalAsync();
            }

        }
    }
}