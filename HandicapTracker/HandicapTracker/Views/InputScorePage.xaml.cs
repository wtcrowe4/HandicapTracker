using HandicapTracker.ViewModels;

namespace HandicapTracker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InputScorePage : ContentPage
    {
        public InputScorePage()
        {
            //InitializeComponent();
            BindingContext = new InputScoreViewModel();
        }

        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    ((InputScoreViewModel)BindingContext).OnAppearing();
        //}

        //private void InitializeComponent() => throw new NotImplementedException();

    }
}