using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FindMe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutMe : ContentPage
    {
        public AboutMe()
        {
            InitializeComponent();
        }
        private void AboveEighteenSwitch_Toggled(object sender, ToggledEventArgs e)
        {

        }
    }
}