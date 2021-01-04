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
    public partial class Answers : ContentPage
    {
        public Answers(int q)
        {
            InitializeComponent();
            answerContent.WidthRequest = answerContainer.Width;

            string quest = "";
            string ans = "";

            switch (q)
            {
                case 1:
                    quest += "什麼樣的食物會影響我的呼吸？";
                    answerContent.Source = "a1.html";
                    var htmlSource = new HtmlWebViewSource();
                    htmlSource.Html = @"<html><body><h3>首先，讓我們來瞭解肺是怎樣工作的，接著你就比較容易能夠瞭解食物和呼吸之間的關係。<img src='a1.jpg'></img><br>當我們吸氣時》肺部吸進氧氣<br>當我們呼氣時》肺部將二氧化按排出體外<br>
<br><br>而COPD患者的肺部，在吸收氧氣、和排出二氧化碳的過程中會有障礙。<br>食物是身體一切活動的原動力,食物轉換為能量的過程中需要消耗氧氣,同時,也產生了二氧化碳。這整個轉換過程,就稱為代謝。日常食物中包含了三大類產生熱量的營養素<br>
碳水化合物 - 脂肪 - 蛋白質<br><br>各種營養素的代謝，需要消耗不同量的氧氣，同時也產生了不同量的二氧化碳。因此,你排出了多少二氧化碳,就看你吃了什麼樣的食物決定。<br>
碳水化合物的代謝需 要最多氧氣・同時也産生了最多的二氧化碳、比較之下，脂肪代謝所產生的二氧化碳則最少。<br></h3></body></html>";
                    answerContent.Source = htmlSource;
                    break;
                case 2:
                    quest += "氣喘患者不能吃冰嗎？";
                    ans += "許多家長或老一輩的人都會傳遞氣喘不能吃冰的觀念，這其實是有科學證據可循的。" +
                        "一份針對國內氣喘病童的研究報告顯示，在喝下冰水後，有47 % 的病童會出現咳嗽、肺功能下降等的氣喘症狀，醫師認為，這可能是因為在喝下冰水後，食道內的冰水溫度刺激到氣管所致。" +
                        "另外，有一項跨國的研究發現，氣喘兒飲用冰水而引發症狀的比例，東方人有63 %，而西方人只有9 %，這樣的差異有可能源自於東西方人體質、飲食習慣的不同。所以在國外，並沒有氣喘不能吃冰這樣的說法，但對台灣人來說，還是要小心為妙，若是真要飲用冰品，也應該要注意不要喝得太猛、或是在運動後氣喘如牛的時候喝才是。";
                    break;
                case 3:
                    quest += "氣喘有辦法根治嗎？&#10;為什麼有人說氣喘兒長大了自己會好？";
                    ans += "以目前的醫學能力無法根治氣喘，但是在良好的治療與控制下，病患可以過著不受束縛的生活。" +
                        "氣喘兒成長間，荷爾蒙變化、免疫系統成熟、以及呼吸道結構改變，的確會使氣喘發作的次數減少，甚至好幾年都沒有發作，但這並不表示根治或痊癒，尤其重感冒後，還是有可能再發作。" +
                        "因此，治療氣喘的目的並不是在「斷根」，而是要與氣喘「和平共存」，過著沒有束縛的優質生活。";
                    break;
                case 4:
                    quest += "長期使用吸入性類固醇，是不是會有副作用？";
                    ans += "吸入性類固醇是目前氣喘治療最有效的藥物，更是國外治療氣喘的首選。它直接作用在呼吸道上，所以劑量的需求遠低於口服劑量，只要依照醫囑使用，就不必擔心全身性的副作用發生。" +
                        "且口腔內念珠菌的感染或聲音沙啞等問題，皆可使用吸藥輔助艙或吸入藥物後漱口來避免。" +
                        "國人認為類固醇會造成月亮臉、傷腎等負面印象，多是因為長期濫用而造成的。只要按照醫師的處方用藥，其實類固醇是一種安全又非常有效的抗發炎藥物。";
                    break;
                case 5:
                    quest += "我覺得現在好多了，可以不要再用藥了嗎？";
                    ans += "氣喘是氣管的慢性發炎所引發的外顯症狀，尤其是中度到重度的氣喘患者，其肺部的發炎是慢性且一直存在的。" +
                        "曾經有醫師做過切片研究，發現患者即使已經有好一陣子沒有急性發作的現象，但是其氣管仍是處在發炎的狀態。" +
                        "氣喘的急性發作較可能是因為天氣冷熱變化太大，冷空氣刺激氣管、或是因為打掃時過多的灰塵、黴菌隨之揚起，刺激氣管等種種原因，對於氣喘患者而言，「有沒有發作」無法當作氣喘控制好壞的指標。" +
                        "最近時序即將由春轉夏，氣候逐漸溼熱穩定，少了乾冷空氣的刺激，氣喘症狀較不易發作，許多氣喘病患因而回診及用藥的意願低，但是沒有症狀不表示氣管的發炎狀況有受到控制。建議患者多與專科醫師討論自己的病情，並聽從醫師的處方建議用藥。";
                    break;
                case 6:
                    quest += "？";
                    ans += "";
                    break;
                case 7:
                    quest += "？";
                    ans += "";
                    break;
                case 8:
                    quest += "？";
                    ans += "";
                    break;
                case 9:
                    quest += "？";
                    ans += "";
                    break;
                case 10:
                    quest += "？";
                    ans += "";
                    break;

            }
            header.Text = quest;
            //textContent.Text = ans;
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