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
            var page = new NavigationPage(new EducationVideo(sen.Text));
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