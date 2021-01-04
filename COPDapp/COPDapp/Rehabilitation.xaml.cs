using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamd.ImageCarousel.Forms.Plugin.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace COPDapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Rehabilitation : ContentPage
    {
        ObservableCollection <FileImageSource> imageSources = new ObservableCollection<FileImageSource>();
        public String[] imgsrc;
        int i = 0;
        public Rehabilitation()
        {
            InitializeComponent();
            imgsrc = new String[] { "smoking_1.png", "smoking_2.png", "smoking_3.png", "smoking_4.png", "smoking_5.png",
                                    "smoking_6.png", "smoking_7.png", "smoking_8.png", "smoking_9.png", "smoking_10.png", "smoking_11.png" };
            int i = 0;
            while (i < imgsrc.Length)
            {
                imageSources.Add(imgsrc[i]);
                i++;
            }
            imgSlider.Images = imageSources;

            //imgView.Source = imgsrc[i];
            //imgView.IsVisible = true;
        }

        //private void BtnNext_Clicked(object sender, EventArgs e)
        //{
        //    if (i < (imgsrc.Length - 1))
        //    {
        //        i++;
        //        btnPrev.IsEnabled = true;
        //    }
        //    if (i == (imgsrc.Length - 1))
        //        btnNext.IsEnabled = false;
        //    imgView.Source = imgsrc[i];
        //}

        //private void BtnPrev_Clicked(object sender, EventArgs e)
        //{
        //    if (i > 0)
        //    {
        //        i--;
        //        btnNext.IsEnabled = true;
        //    }
        //    if (i == 0)
        //        btnPrev.IsEnabled = false;
        //    imgView.Source = imgsrc[i];
        //}

        private void BtnMenu_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var classId = button.ClassId;
            i = 0;
            //if (classId == "smoke") { buttonGrid.IsVisible = true; menuIntro(); }
            //else {
                var page = new NavigationPage(new EducationVideo(classId));
                Navigation.PushModalAsync(page);
            //} 
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