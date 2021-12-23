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
    public partial class SelfAssesment : ContentPage
    {
        public SelfAssesment()
        {
            InitializeComponent();
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            while (Navigation.ModalStack.Count > 0)
            {
                Console.WriteLine("Home button pressed");
                Navigation.PopModalAsync();
            }
        }
    }
}