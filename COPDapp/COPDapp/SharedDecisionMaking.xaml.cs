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
    public partial class SharedDecisionMaking : ContentPage
    {
        public String[] imgList1 = new String[] { "sdm_1.png", "sdm_2.png", "sdm_3.png", "sdm_4.png", "sdm_5.png", "sdm_6.png", "sdm_7.png", "sdm_8.png",
        "sdm_9.png", "sdm_10.png", "sdm_11.png", "sdm_12.png", "sdm_13.png", "sdm_14.png", "sdm_15.png", "sdm_16.png", "sdm_17.png", "sdm_18.png", "sdm_19.png",
        "sdm_20.png", "sdm_21.png", "sdm_22.png", "sdm_23.png", "sdm_24.png", "sdm_25.png"};
        int i = 0;

        public SharedDecisionMaking()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (i < (imgList1.Length - 1))
            {
                i++;
                btnPrev.IsEnabled = true;
            }
            if (i == (imgList1.Length - 1))
                btnNext.IsEnabled = false;
            imgs.Source = ImageSource.FromFile(imgList1[i]);
        }

        private void BtnPrev_Clicked(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                btnNext.IsEnabled = true;
            }
            if (i == 0)
                btnPrev.IsEnabled = false;
            imgs.Source = ImageSource.FromFile(imgList1[i]);
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