namespace INFT2051_W1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        int countMore = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void OnMoreCounterClicked(object? sender, EventArgs e)
        {
            countMore += 2;
            CounterMoreBtn.Text = $"Clicked {countMore} times";
            SemanticScreenReader.Announce((CounterMoreBtn.Text));
        }
    }
}
