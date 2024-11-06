using System.Net;

namespace CatsTheMusical
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked1(object sender, EventArgs e)
        {
            Cat1.Source= "https://cataas.com/cat/says/"+ CatText.Text;
        }
        private void OnCounterClicked2(object sender, EventArgs e)
        {
            Cat2.Source = "https://cataas.com/cat/says/" + CatText.Text + "?fontColor=" + CatTextColor.Text;
        }
        private void OnCounterClicked3(object sender, EventArgs e)
        {
            Cat3.Source = "https://cataas.com/cat"+ "?filter=custom&brightness=" + CatBrightnes.Text;
        }
        private void OnCounterClicked4(object sender, EventArgs e)
        {
            Cat4.Source = "https://cataas.com/cat" + "?filter=custom&brightness=" + CatBrightnes.Text+"&saturation=" +CatSaturation.Text;
        }
        private void OnCounterClicked5(object sender, EventArgs e)
        {
            Cat5.Source = "https://cataas.com/cat" + "?filter="+CatFilter.Text+"&brightness=" + CatBrightnes.Text + "&saturation=" + CatSaturation.Text+ "&filter ="+CatFilter.Text;
        }

    }

}
