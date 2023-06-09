using System.Collections.ObjectModel;
using System.ComponentModel;
using HandicapTracker.Models;

namespace HandicapTracker.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        public const string ViewName = "HomePage";

        public HomePageViewModel()
        {
            Title = "Home";
            MyHandicap = new ObservableCollection<Handicap>();
            HandicapLabel = new Label();
            HandicapLabel.Text = MyHandicap.Value.ToString();

        }

        private ObservableCollection<Handicap> MyHandicap { get; private set; }
        private Label HandicapLabel { get; }

        public void OnAppearing()
        {
            LoadData();
        }

        async void LoadData()
        {
            IEnumerable<Handicap> handicap = await DataStore.GetHandicapAsync(true);
            Handicap.Clear();
            MyHandicap.Add(handicap);
            
        }
    }
}
