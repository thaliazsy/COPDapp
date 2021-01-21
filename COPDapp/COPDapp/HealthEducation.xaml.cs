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
    public partial class HealthEducation : ContentPage
    {
        public HealthEducation(){
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs args){        //點擊某一個按鈕時會執行以下的程式
            Button sen = (Button)sender;
            var page = new NavigationPage(new EducationVideo(sen.Text));    //把 Button.text 傳到下一個頁面來顯示影片
            Navigation.PushModalAsync(page);
        }

        private void Home_Activated(object sender, EventArgs e){            //連到主頁面
            while (Navigation.ModalStack.Count > 0){
                Navigation.PopModalAsync();
            }
        }
    }
}