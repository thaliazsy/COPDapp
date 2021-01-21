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
                    videoBox.Source = "http://203.64.84.218/copd/video/1_肺阻塞_自我檢測.mp4";
                    break;
                case "預防改善":
                    videoBox.Source = "http://203.64.84.218/copd/video/2_肺阻塞_預防改善.mp4";
                    break;
                case "疫苗施打":
                    videoBox.Source  = "http://203.64.84.218/copd/video/3_疫苗施打.mp4";
                    break;
                case "關於肺阻塞":
                    videoBox.Source  = "https://www.tspccm.org.tw/streaming/doc/3/3c1c056316fda357/video/video_src.mp4";
                    videoSource.Text = "影片來源：台灣胸腔暨重症加護醫學會";
                    break;
                case "急性惡化的徵兆及處理":
                    videoBox.Source = "https://www.tspccm.org.tw/streaming/doc/b/b6a59bcd633ce7ff/video/video.mp4";
                    videoSource.Text = "影片來源：台灣胸腔暨重症加護醫學會";
                    break;
                case "肺阻塞的共病症":
                    videoBox.Source = "https://www.tspccm.org.tw/streaming/doc/f/fc4490d535047e0c/video/video.mp4";
                    videoSource.Text = "影片來源：台灣胸腔暨重症加護醫學會";
                    break;
                case "呼吸道痰液清除方法":
                    videoBox.Source  = "https://www.tspccm.org.tw/streaming/doc/0/051996c4dea5d7b0/video/video_src.mp4";
                    videoSource.Text = "影片來源：台灣胸腔暨重症加護醫學會";
                    break;
                case "居家氧氣治療":
                    header.Text = "居家氧氣治療";
                    videoBox.Source  = "https://www.tspccm.org.tw/streaming/doc/6/64d5751294545ba4/video/video_src.mp4";
                    videoSource.Text = "影片來源：台灣胸腔暨重症加護醫學會";
                    break;
                case "Breezehaler":
                    videoBox.Source = "http://203.64.84.218/copd/video/breezehaler.mp4";
                    break;
                case "Ellipta":
                    videoBox.Source = "http://203.64.84.218/copd/video/Ellipta.mp4";
                    break;
                case "MDI With Spacer":
                    videoBox.Source = "http://203.64.84.218/copd/video/MDI_with_spacer.mp4";
                    break;
                case "MDI Without Spacer":
                    videoBox.Source = "http://203.64.84.218/copd/video/MDI_without_spacer.mp4";
                    break;
                case "Respimat":
                    videoBox.Source = "http://203.64.84.218/copd/video/Respimat.mp4";
                    break;
                case "Turbuhaler":
                    videoBox.Source = "http://203.64.84.218/copd/video/Turbuhaler.mp4";
                    break;
                case "復健":
                    videoBox.Source = "http://203.64.84.218/copd/video/what_is_COPD.mp4";
                    break;
                case "營養":
                    videoBox.Source = "http://203.64.84.218/copd/video/DietaryPrinciples.mp4";
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