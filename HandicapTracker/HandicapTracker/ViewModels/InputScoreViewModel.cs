using DevExpress.Maui.DataForm;
using HandicapTracker.Models;
using HandicapTracker.Services;

namespace HandicapTracker.ViewModels
{
    public class InputScoreViewModel : BaseViewModel
    {
        public const string ViewName = "InputScorePage";


        int value;
        DateTime date;
        double courseRating;
        double slopeRating;

        public InputScoreViewModel()
        {
            Title = "Input New Score";
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }


        //Inputs
        //Score
        //Course Rating
        //Slope Rating
        //Date
        public int Value
        {
            get => this.value;
            set => SetProperty(ref this.value, value);
        }

        public DateTime Date
        {
            get => this.date;
            set => SetProperty(ref this.date, value);
        }

        public double CourseRating
        {
            get => this.courseRating;
            set => SetProperty(ref this.courseRating, value);
        }

        public double SlopeRating
        {
            get => this.slopeRating;
            set => SetProperty(ref this.slopeRating, value);
        }


        [DataFormDisplayOptions(IsVisible = false)]
        public Command SaveCommand { get; }

        [DataFormDisplayOptions(IsVisible = false)]
        public Command CancelCommand { get; }


        //bool ValidateSave()
        //{
        //    return !int.IsNullOrWhiteSpace(this.value)
        //        && !String.IsNullOrWhiteSpace(this.description);
        //}

        async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Navigation.GoBackAsync();
        }

        async void OnSave()
        {
            Score newScore= new()
            {
                Id = Guid.NewGuid().ToString(),
                Value = Value,
                Date = Date,
                CourseRating = CourseRating,
                SlopeRating = SlopeRating
            };

            await DataStore.AddItemAsync(newScore);

            // This will pop the current page off the navigation stack
            await Navigation.GoBackAsync();
        }
    }
}