﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

            string quest = "";
            string ans = "";

            //var assembly = IntrospectionExtensions.GetTypeInfo(typeof(Answers)).Assembly;
            //Stream stream = assembly.GetManifestResourceStream("COPDapp.a1.txt");
            //using (var reader = new System.IO.StreamReader(stream))
            //{
            //    ans = reader.ReadToEnd();
            //}

            switch (q)  //請在最底下增加新的答案內容
            {
                case 1:
                    quest += "什麼樣的食物會影響我的呼吸？";
                    ans += "首先，讓我們來瞭解肺是怎樣工作的，接著你就比較容易能夠瞭解食物和呼吸之間的關係。\n\n" +
                        "當我們吸氣時➜肺部吸進氧氣\n當我們呼氣時➜肺部將二氧化按排出體外\n\n" +
                        "而COPD患者的肺部，在吸收氧氣、和排出二氧化碳的過程中會有障礙。\n\n" +
                        "食物是身體一切活動的原動力，食物轉換為能量的過程中需要消耗氧氣，同時，也產生了二氧化碳。這整個轉換過程，就稱為代謝。\n\n" +
                        "日常食物中包含了三大類產生熱量的營養素：\n碳水化合物 - 脂肪 - 蛋白質\n\n" +
                        "各種營養素的代謝，需要消耗不同量的氧氣，同時也產生了不同量的二氧化碳。因此，你排出了多少二氧化碳，就看你吃了什麼樣的食物決定。\n\n" +
                        "碳水化合物的代謝需 要最多氧氣・同時也産生了最多的二氧化碳、比較之下，脂肪代謝所產生的二氧化碳則最少。";
                    break;
                case 2:
                    quest += "我總覺得虛弱， 我應該攝取更多蛋白質嗎？ 我是不是應該像那些馬拉松賽跑選手一樣， 在活動前攝取更多的碳水化合物來增加力氣？";
                    ans += "許多COPD患者·特别那些長期患者，老是容易覺得身體沒力氣。\n\n" +
                        "那可能因為他們體內積聚的二氧化碳太多，或是氧氣吸收量不夠。吃得不夠、或是攝取的食物種類不對，可能會更容易讓虛弱的情況一再發生。\n\n" +
                        "此外，你的身體也會因此而攝取不到足夠的營養。 你的確是需要蛋白質，但攝取較多的蛋白質並不會讓你的活力倍增。雖然在碳水化合物和脂肪缺乏的情况下· 蛋白質也可以當作熱量的來源，但它的主要功能，仍在生成肌肉、血液、以及其他的身體組織。\n\n" +
                        "除此之外，高蛋白質的飲食會刺激呼吸作用，這對健康的人來說沒有什麼顯著影響，卻會使COPD患者增加呼吸困難的狀況。攝取大量的碳水化合物，能夠供給賽跑 者能量，但這樣也會產生較多的二氧化碳，所以，你必須做較深的呼吸，並增加呼吸次數，以便排出二氧化碳 。這對一些COPD患者來說是很困難的。因此你的醫師、 或營養師。可能會建議你攝取較少的碳水化合物。同時攝取較多的脂肪。脂肪是很好的熱量來源。而且它產生的二氧化碳量也比碳水化合物来得少。\n\n" +
                        "如果你目前每天攝取的熱量，沒有營養師所建議的那麼多，那麼就盡可能地多吃高脂肪的食物，來提高熱量的攝取。當你攝取了足夠熱量，那麼，在同等熱量的前提下、你可以試著以高脂肪含量的食物・來取代富含碳水化合物的食物。這樣就能夠減少體內二氧化碳的產生。進而讓你覺得較為舒服。\n\n";
                    break;
                case 3:
                    quest += "我很擔心膽固醇和飽和脂肪酸，所以，我一直在減少攝取脂肪。如果，飲食中脂肪的攝取量增加。會不會讓我的膽固醇升高呢？";
                    ans += "並非所有的脂肪都富含膽固醇和飽和脂肪酸。大部分含高膽固醇、飽和脂肪酸的食物屬於動物性的來源，飽和脂肪在低溫下會凝固，這就是判別的一種方式。舉例來說，想想看家裡冰箱中那鍋牛肉或雞湯， 上頭都會浮著一層固態脂肪。而多元不飽和脂肪酸並不含膽固醇。這些脂肪大多屬於植物性來源，在低溫下仍會保持液狀。\n\n" +
                        "例如：菜籽油(Canola Oil;或者低芥子酸油)、葵花子油 ·以及玉米油。\n\n" +
                        "當你在飲食中需要增加脂肪的攝取量時，請多選用不飽和脂肪酸。你可以用液狀的蔬菜油來烹調食物。避免食用奶油和肥肉之颊的動物脂肪·因為這些食物含有大量的飽和脂肪酸以及膽固醇。\n\n" +
                        "在你買下任何加工食品時，先看看包裝上的標示。許多加工食品會在標示的營養成分表上註明膽固醇的含量。 如果同類食物，有一種用了純奶油而另一種用了菜籽油(Canola Oil)請選擇使用菜籽油製成的食品。";
                    break;
                case 4:
                    quest += "我在飽餐一頓後，總是會覺得呼吸困難。我要如何吃得好、又不會覺得不舒服呢？";
                    ans += "你身體內的器官並非緊密相鄰，它們之間是有空隙的。肺和胃之間的空隙中有個肌肉膜，我們稱之為「橫隔膜」。\n\n" +
                        "當你吸氣時》橫膈膜會下降\n當你呼氣時》橫膈膜會上升\n\n" +
                        "一個充滿食物的胃·會使橫膈膜之間的空隙縮小，橫膈膜因此無法完全下降，進而使得肺部無法完全充氣，所以你就不能舒服的呼吸。\n\n" +
                        "我們建議的對策：\n" +
                        "請試著將你一天所要吃的食物。分為五到六次進食。避免在三餐內就將全部的份量吃完。如此，你的胃才不會在每次用完餐後漲得太大。你可以在早餐、中餐和晚餐都吃得少一點，然後在每餐之間用些點心，每天二到三次，以補足身體所需的營養。";
                    break;
                case 5:
                    quest += "我吃得很多，但我的體重還是持續減輕，為什麼會這樣呢？";
                    ans += "體重下降的原因是你消耗的熱量比你攝取的熱量來得多。或許你所攝取的熱量並沒有你想像中的多。你可以將每天自己的飲食內容作記錄。持續幾天後做個統計。醫院的營養師會樂於教你如何做這件事。\n\n" +
                        "更有可能的是你身體所消耗的熱量，比你想像中的要多。大部分的人都認為我們應該多做運動，以便燃燒多餘的熱量。事實上，我們的身體也一直持續地利用熱量 ，作為呼吸和抵抗感染的能量來源。\n\n" +
                        "體重下降是COPD病患普遍面臨的問題・原因文之一是他們要比常人消耗更多的熱量在呼吸上。同樣進行呼吸時，一個肺部患有疾病的病人，要比健康的人多消耗10 倍的熱量。";
                    break;
                case 6:
                    quest += "如果我吃得比較多，會不會因此而變胖？";
                    ans += "變胖的唯一原因是你所攝取的熱量，超過了你身體所消耗的數量。營養師可為你計算出一天所需的熱量，營養師也會根據這份結果建議你一天要攝取多少熱量。請遵照營養師的建議來攝取所需的熱量 ，千萬別攝取過量了，過多的熱量常會讓你腹圍變大。 反而增加身體負荷。\n\n" +
                        "體重過重會讓你需要更多的氧氣，也會影響到你的呼吸。同時，吃得太多一特别是過多的碳水化合物一也會讓你的呼吸更為吃力。\n\n" +
                        "請養成定期量體重的習慣。磅秤不僅讓你知道體重是否增加了，也會警告你無意中的體重減輕。如果你已經遵守醫師或營養師的飲食建議，體重卻還是持續減輕， 請務必諮詢醫師或營養師。";
                    break;
                case 7:
                    quest += "如果我沒辦法吃得像營養師所建議的那麼多。我該怎麼辦？";
                    ans += "你可能會發現光靠攝取正常的三餐，並無法滿足你的營養需求，尤其是當你一天需要很高的熱量時。" +
                        "如果營養師建議你一天攝取的熱量中，要有一半來自脂肪一而且主要來自低膽固醇的不飽和脂肪一 你可能就無法光靠一般食物，單純地達到這個目標。" +
                        "在這個時候。營養師或醫師可能會建議你喝一種特殊營養品。許多需要更多熱量的人，都將這種特殊營養品規劃到他們的飲食中。" +
                        "有些人無法攝取一般性的食物，這類特殊營養品可以經過醫護人員指示後，完全取代他們的正餐;而對於無法經一般方式攝取足夠營養的人，這類特殊食品也可以成為很好的營養補充品。";
                    break;
                case 8:
                    quest += "我的醫師告訴我要注意水分和液體的攝取。 道是不是表示我不能使用流質的特殊營養品？";
                    ans += "體内水分的存留量·和你的水分消耗量、以及你攝取的「鈉」量有關。「鈉」的攝取主要來自於調味的鹽，以及鹽釀的食物、食物中天然的「鈉」、以及食物加工過程中添加進去的「鈉」。\n\n" +
                        "鹹味的食物請循醫師指示限量攝取，水分也視情況酌量控制。\n\n" +
                        "同時也要應避免攝取營養價值很低的一般冷/熱飲料。\n\n" +
                        "喝飲料前不妨先自問：用餐之間真的需要喝這些飲料嗎？看球賽時可否不喝啤酒呢？將這些飲料省掉，吃那些營養師所建議的營養食物和點心吧，其中也可包括流質的特殊營養品。\n\n" +
                        "如果你吃的是限鈉飲食、以及/或是限水飲食，請 營養師請教。請對方幫你計畫飲食的內容。要記得哪些食物是富含水分的。例如一杯含很多膠質的點心，水分含量可能和一杯柳橙汁一様多。";
                    break;
                case 9:
                    quest += "改變飲食内容·能狗治癒我的肺部疾病嗎？";
                    ans += "不能。改愛飲食内容並不能治癒COPD。但是改變飲食內容卻可以讓你呼吸得更為順暢，你的生活也會因而更愉快。\n\n" +
                        "攝取足夠滿足身體所需熱量的食物，才能讓你有力氣去做你想要做的事。飲食中的蛋白質·碳水化合物以及脂肪的 組合比例正確，能幫助你呼吸得更好。\n\n" +
                        "適當的飲食，再加上醫師建議的運動，能幫助你保持四肢肌肉的強壯，也能夠讓你的心臟和肺臟得到充足的氧氧。只要能做到上述幾項・即使你是個COPD患者・ 一樣可以盡情享受快樂的人生。 ";
                    break;
                case 10:
                    quest += "若將我的飲食作些改變，就能夠讓我不生重病嗎？";
                    ans += "良好的飲食並不會有百病不侵的神奇效果。不論人們吃得多好，還是偶爾會生病。然而，一個營養充 足的人一旦生病，會比那些營養不足的人復原得快。同樣 是輕微的流鼻水，一個營養充足的人最多是患個五天的感冒，但一個營養不足的人卻可能會併發為肺炎。\n\n" +
                        "你可能會發現自己偶爾還是得看看醫生，或藉助機器的幫助來呼吸。但是只要你的營養狀況良好，你就能儘早脫離這些機器的牽絆。\n在飲食上做改變並不能讓你完全不接受呼吸治療，但是卻能讓你減少進醫院的頻率，因為你的營養狀況變好了， 同時，你也能夠早日出院回家。";
                    break;
                //在此新增新的問答。
            }
            header.Text = quest;
            textContent.Text = ans;
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