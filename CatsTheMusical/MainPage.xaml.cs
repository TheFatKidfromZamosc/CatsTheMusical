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

        private void OnCounterClicked(object sender, EventArgs e)
        {
        
            Cat1.Source= "https://cataas.com/cat";
        }
    }

}
