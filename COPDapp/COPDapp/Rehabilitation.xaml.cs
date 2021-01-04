using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace COPDapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Rehabilitation : ContentPage
    {
        public Rehabilitation()
        {
            InitializeComponent();
        }

        private void BtnMenu_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var classId = button.ClassId;
            if (classId == "smoke") {
                String[] imgsrc = new String[] { "smoking_1.png", "smoking_2.png", "smoking_3.png", "smoking_4.png", "smoking_5.png",
                                    "smoking_6.png", "smoking_7.png", "smoking_8.png", "smoking_9.png", "smoking_10.png", "smoking_11.png" };
                var page = new NavigationPage(new slideshowDisplay(imgsrc));
                Navigation.PushModalAsync(page);
            }
            else{
                var page = new NavigationPage(new EducationVideo(classId));
                Navigation.PushModalAsync(page);
            } 
        }
        void onContentViewSizeChanged(object sender, EventArgs args)
        {
            View view = (View)sender;
            double lineHeight = Device.RuntimePlatform == Device.iOS ||
                                Device.RuntimePlatform == Device.Android ? 1.2 : 1.3;

            double charWidth = 0.5;
            int fontSize = (int)Math.Sqrt(view.Width * view.Height /
                            (2 * lineHeight * charWidth));
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