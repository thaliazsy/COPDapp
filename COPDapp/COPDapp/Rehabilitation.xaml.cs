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
    public partial class Rehabilitation : ContentPage
    {
        public String[] imgsrc;
        int i = 0;
        public Rehabilitation()
        {
            InitializeComponent();
        }
        private void menuIntro()
        {
            imgsrc = new String[] { "smoking_1.png", "smoking_2.png", "smoking_3.png", "smoking_4.png", "smoking_5.png",
                                    "smoking_6.png", "smoking_7.png", "smoking_8.png", "smoking_9.png", "smoking_10.png", "smoking_11.png" };
            lbl0.Text = "戒菸";
            imgView.Source = imgsrc[i];
            imgView.IsVisible = true;
        }

        private void menuPrevent()
        {
            videoView.Source="http://203.64.84.218/copd/video/what_is_COPD.mp4";
            lbl0.Text = "復健";
            lbl0.IsVisible = false;
            videoLayout.IsVisible = true;
        }

        private void menuLastStage()
        {
            videoView.Source = "http://203.64.84.218/copd/video/DietaryPrinciples.mp4";
            lbl0.Text = "營養";
            lbl0.IsVisible = false;
            videoLayout.IsVisible = true;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (i < (imgsrc.Length - 1))
            {
                i++;
                btnPrev.IsEnabled = true;
            }
            if (i == (imgsrc.Length - 1))
                btnNext.IsEnabled = false;
            imgView.Source = imgsrc[i];
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
            imgView.Source = imgsrc[i];
        }

        private void BtnMenu_Clicked(object sender, EventArgs e)
        {
           
            i = 0;
            if (((Button)sender).Text == "戒菸") { videoLayout.IsVisible = false; buttonGrid.IsVisible = true; menuIntro(); }
            else if (((Button)sender).Text == "復健") { imgView.IsVisible = false; lbl1.IsVisible = false; buttonGrid.IsVisible = false; menuPrevent(); }
            else if (((Button)sender).Text == "營養") { imgView.IsVisible = false; lbl1.IsVisible = false; buttonGrid.IsVisible = false; menuLastStage(); }

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