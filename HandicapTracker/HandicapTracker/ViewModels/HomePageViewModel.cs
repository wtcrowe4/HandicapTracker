using System.Collections.ObjectModel;
using System.ComponentModel;
using HandicapTracker.Models;


namespace HandicapTracker.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        
        public const string ViewName = "HomePage";
        public string Handicap { get; set; }

        public HomePageViewModel()
        {
            Title = "Home";
            Handicap = "2.3";
            
        } 

            //MyHandicap = new ObservableCollection<Handicap>();
            //HandicapLabel = new Label();
            //HandicapLabel.Text = MyHandicap[0].Value.ToString();

    }

        //private ObservableCollection<Handicap> MyHandicap { get; }
        //private Label HandicapLabel { get; }

        //public void OnAppearing()
        //{
           
        //}

        //async void LoadData()
        //{
            
            
        //}
    
}


