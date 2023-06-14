using HandicapTracker.Models;
using System.Collections.ObjectModel;

namespace HandicapTracker.ViewModels
{
    public class DataGridViewModel : BaseViewModel
    {
        public DataGridViewModel()
        {
            Title = "DataGridView";
            //Items = new ObservableCollection<Item>();
            Scores = new ObservableCollection<Score>();
        }

        //public ObservableCollection<Item> Items { get; private set; }
        public ObservableCollection<Score> Scores { get; private set; }

        async public void OnAppearing()
        {
            //IEnumerable<Item> items = await DataStore.GetItemsAsync(true);
            //Items.Clear();
            //foreach (Item item in items)
            //{
            //    Items.Add(item);
            //}
            IEnumerable<Score> scores = await DataStore.GetScoresAsync(true) as IEnumerable<Score>;
            Scores.Clear();
            foreach (Score score in scores)
            {
                Scores.Add(score);
            }
        }
    }
}