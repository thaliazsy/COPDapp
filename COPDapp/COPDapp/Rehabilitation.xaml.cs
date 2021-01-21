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

        private void BtnMenu_Clicked(object sender, EventArgs e)				//點擊某一個按鈕時會執行以下的程式
        {
            var sen = (Button)sender;
            if (sen.Text == "戒菸") {	//點擊“戒菸”該按鈕時，會連到下一個頁面來顯示圖片
                String[] imgsrc = new String[] {"smoking_1.png", "smoking_2.png", "smoking_3.png", "smoking_4.png",
												"smoking_5.png", "smoking_6.png", "smoking_7.png", "smoking_8.png", 
												"smoking_9.png", "smoking_10.png", "smoking_11.png" };	//圖片來源
                var page = new NavigationPage(new slideshowDisplay(imgsrc));	//把一系列的圖片來源傳到下一個頁面
                Navigation.PushModalAsync(page);
            }
            else{						//點擊“復健”以及“營養”該按鈕時，會連到下一個網頁來顯示影片
                var page = new NavigationPage(new EducationVideo(sen.Text));	//把 Button.text 傳到下一個頁面
                Navigation.PushModalAsync(page);
            } 
        }

        private void Home_Activated(object sender, EventArgs e)					//連到主頁面
        {
            foreach (Page page in Navigation.ModalStack)
            {
                Navigation.PopModalAsync();
            }
        }
    }
}