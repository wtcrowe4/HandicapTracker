using HandicapTracker.ViewModels;

namespace HandicapTracker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewItemPage : ContentPage
    {
        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new InputScoreViewModel();
        }
    }
}