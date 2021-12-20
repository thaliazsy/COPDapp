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
                    videoBox.Source = "COPD_Self_Evaluation.mp4";
                    break;
                case "預防改善":
                    videoBox.Source = "Prevent_Improve_COPD.mp4";
                    break;
                case "疫苗施打":
                    videoBox.Source  = "http://203.64.84.218/copd/vidgeo/3_疫苗施打.mp4";
                    break;
                case "關於肺阻塞":
                    videoBox.Source  = "About_COPD.mp4";
                    videoSource.Text = "影片來源：台灣胸腔暨重症加護醫學會";
                    break;
                case "急性惡化的徵兆及處理":
                    videoBox.Source = "Acute_Exacerbations_of_COPD.mp4";
                    videoSource.Text = "影片來源：台灣胸腔暨重症加護醫學會";
                    break;
                case "肺阻塞的共病症":
                    videoBox.Source = "Comorbidities_of_COPD.mp4";
                    videoSource.Text = "影片來源：台灣胸腔暨重症加護醫學會";
                    break;
                case "呼吸道痰液清除方法":
                    videoBox.Source  = "Sputum_Removal.mp4";
                    videoSource.Text = "影片來源：台灣胸腔暨重症加護醫學會";
                    break;
                case "居家氧氣治療":
                    header.Text = "居家氧氣治療";
                    videoBox.Source  = "Home_Oxygen_Therapy.mp4";
                    videoSource.Text = "影片來源：台灣胸腔暨重症加護醫學會";
                    break;
                case "Breezehaler":
                    videoBox.Source = "breezehaler.mp4";
                    break;
                case "Ellipta":
                    videoBox.Source = "Ellipta.mp4";
                    break;
                case "MDI With Spacer":
                    videoBox.Source = "MDI_with_spacer.mp4";
                    break;
                case "MDI Without Spacer":
                    videoBox.Source = "MDI_without_spacer.mp4";
                    break;
                case "Respimat":
                    videoBox.Source = "Respimat.mp4";
                    break;
                case "Turbuhaler":
                    videoBox.Source = "Turbuhaler.mp4";
                    break;
                case "復健":
                    videoBox.Source = "http://203.64.84.218/copd/video/what_is_COPD.mp4";
                    break;
                case "營養":
                    videoBox.Source = "DietaryPrinciples.mp4";
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