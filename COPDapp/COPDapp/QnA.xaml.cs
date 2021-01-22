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
    public partial class QnA : ContentPage
    {
        public QnA()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            ImageButton sen = (ImageButton)sender;
            int question = 0;

            if (sen == sen.FindByName("q1"))
            {
                question = 1;
            }
            else if (sen == sen.FindByName("q2"))
            {
                question = 2;
            }
            else if (sen == sen.FindByName("q3"))
            {
                question = 3;
            }
            else if (sen == sen.FindByName("q4"))
            {
                question = 4;
            }
            else if (sen == sen.FindByName("q5"))
            {
                question = 5;
            }
            else if (sen == sen.FindByName("q6"))
            {
                question = 6;
            }
            else if (sen == sen.FindByName("q7"))
            {
                question = 7;
            }
            else if (sen == sen.FindByName("q8"))
            {
                question = 8;
            }
            else if (sen == sen.FindByName("q9"))
            {
                question = 9;
            }
            else if (sen == sen.FindByName("q10"))  //使用button的名稱Name來判斷
            {
                question = 10;
            }

            var page = new NavigationPage(new Answers(question));   //傳到新的頁面
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