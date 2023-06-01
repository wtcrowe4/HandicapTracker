namespace HandicapTracker.Views.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePagePage : ContentPage
    {
        public HomePagePage()
        {
            InitializeComponent();
            BindingContext = new HomePageViewModel();
        }
    }
}
