using HandicapTracker.ViewModels;

namespace HandicapTracker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage: ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomePageViewModel();
        }
    }
}
