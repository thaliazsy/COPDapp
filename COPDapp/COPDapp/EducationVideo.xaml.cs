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
            switch (video)
            {
                case "selfAsses":
                    header.Text = "肺阻塞 自我檢測";
                    videoBox.Source = "http://203.64.84.218/copd/video/1_肺阻塞_自我檢測.mp4";
                    break;
                case "prevention":
                    header.Text = "肺阻塞 預防改善";
                    videoBox.Source = "http://203.64.84.218/copd/video/2_肺阻塞_預防改善.mp4";
                    break;
                case "vaccine":
                    header.Text = "疫苗施打";
                    videoBox.Source  = "http://203.64.84.218/copd/video/3_疫苗施打.mp4";
                    break;
                case "aboutCOPD":
                    header.Text = "關於肺阻塞";
                    videoBox.Source  = "https://www.tspccm.org.tw/streaming/doc/3/3c1c056316fda357/video/video_src.mp4";
                    videoSource.Text = "影片來源：台灣胸腔暨重症加護醫學會";
                    break;
                case "acuteExacerbation":
                    header.Text = "急性惡化的徵兆及處理";
                    videoBox.Source = "https://www.tspccm.org.tw/streaming/doc/b/b6a59bcd633ce7ff/video/video.mp4";
                    videoSource.Text = "影片來源：台灣胸腔暨重症加護醫學會";
                    break;
                case "comorbidity":
                    header.Text = "肺阻塞的共病症";
                    videoBox.Source = "https://www.tspccm.org.tw/streaming/doc/f/fc4490d535047e0c/video/video.mp4";
                    videoSource.Text = "影片來源：台灣胸腔暨重症加護醫學會";
                    break;
                case "mucusRemoval":
                    header.Text = "呼吸道痰液清除方法";
                    videoBox.Source  = "https://www.tspccm.org.tw/streaming/doc/0/051996c4dea5d7b0/video/video_src.mp4";
                    videoSource.Text = "影片來源：台灣胸腔暨重症加護醫學會";
                    break;
                case "oxygenTherapy":
                    header.Text = "居家氧氣治療";
                    videoBox.Source  = "https://www.tspccm.org.tw/streaming/doc/6/64d5751294545ba4/video/video_src.mp4";
                    videoSource.Text = "影片來源：台灣胸腔暨重症加護醫學會";
                    break;
                case "breezehaler":
                    header.Text = "藥物 Breezehaler";
                    videoBox.Source = "http://203.64.84.218/copd/video/breezehaler.mp4";
                    break;
                case "ellipta":
                    header.Text = "藥物 Ellipta";
                    videoBox.Source = "http://203.64.84.218/copd/video/Ellipta.mp4";
                    break;
                case "mdiWspacer":
                    header.Text = "藥物 MDI with Spacer";
                    videoBox.Source = "http://203.64.84.218/copd/video/MDI_with_spacer.mp4";
                    break;
                case "MDIWOspacer":
                    header.Text = "藥物 MDI without Spacer";
                    videoBox.Source = "http://203.64.84.218/copd/video/MDI_without_spacer.mp4";
                    break;
                case "respimat":
                    header.Text = "藥物 Respimat";
                    videoBox.Source = "http://203.64.84.218/copd/video/Respimat.mp4";
                    break;
                case "turbuhaler":
                    header.Text = "藥物 Turbuhaler";
                    videoBox.Source = "http://203.64.84.218/copd/video/Turbuhaler.mp4";
                    break;
                case "rehabilitation":
                    header.Text = "復健";
                    videoBox.Source = "http://203.64.84.218/copd/video/what_is_COPD.mp4";
                    break;
                case "nutrition":
                    header.Text = "營養";
                    videoBox.Source = "http://203.64.84.218/copd/video/DietaryPrinciples.mp4";
                    break;
            }
        }

        private double width = 0;
        private double height = 0;
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (width != this.width || height != this.height)
            {
                this.width = width;
                this.height = height;
                if (width > height)
                {
                    videoBox.HorizontalOptions = LayoutOptions.CenterAndExpand;
                }
                else
                {
                    videoBox.VerticalOptions = LayoutOptions.CenterAndExpand;
                }
            }
        }

        void OnMediaOpened(object sender, EventArgs e)
        {
            alert.Text = "";
        }

        void OnMediaFailed(object sender, EventArgs e)
        {
            alert.TextColor = Color.Red;
            alert.Text = "影片載入失敗，請重新載入。";
        }

        void OnMediaEnded(object sender, EventArgs e)
        {

        }

        void OnSeekCompleted(object sender, EventArgs e)
        {

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