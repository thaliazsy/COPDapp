using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace COPDapp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnButtonClicked(object sender, EventArgs args)
        {
            ImageButton sen = (ImageButton)sender;
            //label1.Text = sen.Text.ToString();
            if (sen == sen.FindByName("button_edu"))
            {
                var page = new NavigationPage(new HealthEducation());
                Navigation.PushModalAsync(page);
            }
            else if (sen == sen.FindByName("button_therapy"))
            {
                var page = new NavigationPage(new Rehabilitation());
                Navigation.PushModalAsync(page);
            }
            else if (sen == sen.FindByName("button_decision"))
            {
                var page = new NavigationPage(new SharedDecisionMaking());
                Navigation.PushModalAsync(page);
            }
            else if (sen == sen.FindByName("button_drug"))
            {
                var page = new NavigationPage(new Drug());
                Navigation.PushModalAsync(page);
            }
        }
    }

    public class TextShadowButton : Button
    {
        public static readonly BindableProperty TextShadowColorProperty =
        BindableProperty.Create(
        nameof(TextShadowColor),
        typeof(Color),
        typeof(TextShadowButton),
        Color.Gray);

        /// <summary>
        /// Gets or Sets TextShadowColor property
        /// </summary>
        public Color TextShadowColor
        {
            get
            {
                return (Color)GetValue(TextShadowColorProperty);
            }
            set
            {
                SetValue(TextShadowColorProperty, value);
            }
        }
    }
}
