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
    public partial class Drug : ContentPage
    {
        public Drug()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs args)
        {
            Button sen = (Button)sender;
            //label1.Text = sen.Text.ToString();
            string video="";
            if (sen == sen.FindByName("btn_breezehaler"))
            {
                video = "breezehaler";
            }
            else if (sen == sen.FindByName("btn_ellipta"))
            {
                video = "ellipta";
            }
            else if (sen == sen.FindByName("btn_mdiWspacer"))
            {
                video = "mdiWspacer";
            }
            else if (sen == sen.FindByName("btn_mdiWOspacer"))
            {
                video = "mdiWOspacer";
            }
            else if (sen == sen.FindByName("btn_respimat"))
            {
                video = "respimat";
            }
            else if (sen == sen.FindByName("btn_turbuhaler"))
            {
                video = "turbuhaler";
            }
            var page = new NavigationPage(new EducationVideo(video));
            Navigation.PushModalAsync(page);
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            while (Navigation.ModalStack.Count > 0)
            {
                Navigation.PopModalAsync();
            }
        }
    }
}