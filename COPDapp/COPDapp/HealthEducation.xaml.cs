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
    public partial class HealthEducation : ContentPage
    {
        public HealthEducation()
        {
            InitializeComponent();
            IList<View> buttons = container.Children;
            foreach(Button b in buttons)
            {
                b.BackgroundColor = Color.Orange;
                b.FontSize = 50;
            }
        }

        private void OnButtonClicked(object sender, EventArgs args)
        {
            Button sen = (Button)sender;
            //label1.Text = sen.Text.ToString();
            string video="";
            if (sen == sen.FindByName("btn_selfAsses"))  //self assesment video
            {
                video = "selfAsses";
            }
            else if (sen == sen.FindByName("btn_prevention")) //prevention video
            {
                video = "prevention";
            }
            else if (sen == sen.FindByName("btn_vaccine")) //vaccine video
            {
                video = "vaccine";
            }
            else if (sen == sen.FindByName("btn_aboutCOPD"))
            {
                video = "aboutCOPD";
            }
            else if (sen == sen.FindByName("btn_acuteExacerbation"))
            {
                video = "acuteExacerbation";
            }
            else if (sen == sen.FindByName("btn_comorbidity"))
            {
                video = "comorbidity";
            }
            else if (sen == sen.FindByName("btn_mucusRemoval"))
            {
                video = "mucusRemoval";
            }
            else if (sen == sen.FindByName("btn_oxygenTherapy"))
            {
                video = "oxygenTherapy";
            }

            var page = new NavigationPage(new EducationVideo(video));
            Navigation.PushModalAsync(page);
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