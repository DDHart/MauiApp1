namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        int loc = 0;
        String[] arrPics = { "animal1.jpeg", "animal2.jpeg", "animal3.jpeg"};


        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void GoUpClicked(object sender, EventArgs e)
        {
            loc = (loc+1) % arrPics.Length;
            ChangeImg.Source = arrPics[loc];

        }

        private void GoDownClicked(object sender, EventArgs e)
        {
            loc--;
            if(loc < 0) loc = arrPics.Length - 1;

            ChangeImg.Source = arrPics[loc];

        }
    }

}
