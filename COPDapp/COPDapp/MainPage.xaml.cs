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
            else if (sen == sen.FindByName("button_therapy"))
            {
                var page = new NavigationPage(new Rehabilitation());
                Navigation.PushModalAsync(page);
            }
            else if (sen == sen.FindByName("button_decision"))
            {
                var page = new NavigationPage(new SharedDecisionMaking());
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
