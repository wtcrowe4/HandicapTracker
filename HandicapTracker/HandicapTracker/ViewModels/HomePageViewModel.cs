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
            Handicap = new Handicap();
            HandicapLabel = new Label();
            HandicapLabel.Text = Handicap.Value.ToString();

        }

        private Handicap Handicap { get; } 
        private Label HandicapLabel { get; }
    }
}
