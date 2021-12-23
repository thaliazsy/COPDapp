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
    public partial class EducationVideo : ContentPage
    {
        public EducationVideo(string video)
        {
            InitializeComponent();
            header.FontSize = 40;
            header.Text = video;
            switch (video)
            {
                case "自我檢測":
                    videoBox.Source = "ms-appx:///COPD_Self_Evaluation.mp4";
                    break;
                case "預防改善":
                    videoBox.Source = "ms-appx:///Prevent_Improve_COPD.mp4";
                    break;
                case "疫苗施打":
                    videoBox.Source  = "http://203.64.84.218/copd/vidgeo/3_疫苗施打.mp4";
                    break;
                case "關於肺阻塞":
                    videoBox.Source  = "ms-appx:///About_COPD.mp4";
                    videoSource.Text = "影片來源：台灣胸腔暨重症加護醫學會";
                    break;
                case "急性惡化的徵兆及處理":
                    videoBox.Source = "ms-appx:///Acute_Exacerbations_of_COPD.mp4";
                    videoSource.Text = "影片來源：台灣胸腔暨重症加護醫學會";
                    break;
                case "肺阻塞的共病症":
                    videoBox.Source = "ms-appx:///Comorbidities_of_COPD.mp4";
                    videoSource.Text = "影片來源：台灣胸腔暨重症加護醫學會";
                    break;
                case "呼吸道痰液清除方法":
                    videoBox.Source  = "ms-appx:///Sputum_Removal.mp4";
                    videoSource.Text = "影片來源：台灣胸腔暨重症加護醫學會";
                    break;
                case "居家氧氣治療":
                    header.Text = "居家氧氣治療";
                    videoBox.Source  = "ms-appx:///Home_Oxygen_Therapy.mp4";
                    videoSource.Text = "影片來源：台灣胸腔暨重症加護醫學會";
                    break;
                case "Breezehaler":
                    videoBox.Source = "ms-appx:///breezehaler.mp4";
                    break;
                case "Ellipta":
                    videoBox.Source = "ms-appx:///Ellipta.mp4";
                    break;
                case "MDI With Spacer":
                    videoBox.Source = "ms-appx:///MDI_with_spacer.mp4";
                    break;
                case "MDI Without Spacer":
                    videoBox.Source = "ms-appx:///MDI_without_spacer.mp4";
                    break;
                case "Respimat":
                    videoBox.Source = "ms-appx:///Respimat.mp4";
                    break;
                case "Turbuhaler":
                    videoBox.Source = "ms-appx:///Turbuhaler.mp4";
                    break;
                case "復健":
                    videoBox.Source = "ms-appx:///What_is_COPD.mp4";
                    break;
                case "營養":
                    videoBox.Source = "ms-appx:///DietaryPrinciples.mp4";
                    break;
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "OnlyLandscape");
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Send(this, "Unspecified");
        }

        void OnMediaOpened(object sender, EventArgs e)
        {
            ai_layout.IsVisible = false;
            ai.IsRunning = false;
            ai.IsEnabled = false;
            ai.IsVisible = false;
        }

        void OnMediaFailed(object sender, EventArgs e)
        {
            header.Text += "\n影片載入失敗，請重新載入。";
            header.TextColor= Color.Red;
            ai.IsRunning = false;
            ai.IsEnabled = false;
            ai.IsVisible = false;
        }
    }

}