using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace COPDapp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            title.Text = "Tzu Chi Hospital\nCOPD APP";
        }
        private void OnButtonClicked(object sender, EventArgs args)
        {
            ImageButton sen = (ImageButton)sender;
            //label1.Text = sen.Text.ToString();
            if (sen == sen.FindByName("button_edu"))
            {
                var page = new NavigationPage(new HealthEducation());
                Navigation.PushModalAsync(page);
            }
            else if (sen == sen.FindByName("button_selfAsses"))
            {
                var page = new NavigationPage(new SelfAssesment());
                Navigation.PushModalAsync(page);
            }
            else if (sen == sen.FindByName("button_therapy"))
            {
                var page = new NavigationPage(new Rehabilitation());
                Navigation.PushModalAsync(page);
            }
            else if (sen == sen.FindByName("button_decision"))
            {
                String[] imgsrc = new String[] { "sdm_1.png", "sdm_2.png", "sdm_3.png", "sdm_4.png", "sdm_5.png", "sdm_6.png", "sdm_7.png", "sdm_8.png",
                "sdm_9.png", "sdm_10.png", "sdm_11.png", "sdm_12.png", "sdm_13.png", "sdm_14.png", "sdm_15.png", "sdm_16.png", "sdm_17.png", "sdm_18.png", "sdm_19.png",
                "sdm_20.png", "sdm_21.png", "sdm_22.png", "sdm_23.png", "sdm_24.png", "sdm_25.png"};

                var page = new NavigationPage(new slideshowDisplay(imgsrc));
                Navigation.PushModalAsync(page);
            }
            else if (sen == sen.FindByName("button_drug"))
            {
                var page = new NavigationPage(new Drug());
                Navigation.PushModalAsync(page);
            }
            else if (sen == sen.FindByName("button_qna"))
            {
                var page = new NavigationPage(new QnA());
                Navigation.PushModalAsync(page);
            }
        }
    }
}
