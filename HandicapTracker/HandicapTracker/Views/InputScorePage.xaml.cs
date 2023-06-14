using HandicapTracker.ViewModels;

namespace HandicapTracker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InputScorePage : ContentPage
    {
        public InputScorePage()
        {
            InitializeComponent();
            BindingContext = new InputScoreViewModel();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}