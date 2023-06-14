using HandicapTracker.Models;
using System.Collections.ObjectModel;

namespace HandicapTracker.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        //Item _selectedItem;


        public ItemsViewModel()
        {
            Title = "Browse";
            Scores = new ObservableCollection<Score>();
            //Items = new ObservableCollection<Item>();
            //LoadItemsCommand = new Command(() => ExecuteLoadItemsCommand());
            //ItemTapped = new Command<Item>(OnItemSelected);
            //AddItemCommand = new Command(OnAddItem);
        }
            
        public ObservableCollection<Score> Scores { get; }

    //    public ObservableCollection<Item> Items { get; }

    //    public Command LoadItemsCommand { get; }

    //    public Command AddItemCommand { get; }

    //    public Command<Item> ItemTapped { get; }

    //    public Item SelectedItem
    //    {
    //        get => this._selectedItem;
    //        set
    //        {
    //            SetProperty(ref this._selectedItem, value);
    //            OnItemSelected(value);
    //        }
    //    }

    //    public void OnAppearing()
    //    {
    //        IsBusy = true;
    //        SelectedItem = null;
    //        ExecuteLoadItemsCommand();
    //    }

    //    void ExecuteLoadItemsCommand()
    //    {
    //        IsBusy = true;
    //        try
    //        {
    //            Items.Clear();
    //            var items = DataStore.GetItems(true);
    //            foreach (var item in items)
    //            {
    //                item.Text = item.Text;
    //                Items.Add(item);
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            System.Diagnostics.Debug.WriteLine(ex);
    //        }
    //        finally
    //        {
    //            IsBusy = false;
    //        }
    //    }

    //    async void OnAddItem(object obj)
    //    {
    //        await Navigation.NavigateToAsync<InputScoreViewModel>(null);
    //    }

    //    async void OnItemSelected(Item item)
    //    {
    //        if (item == null)
    //            return;
    //        await Navigation.NavigateToAsync<ItemDetailViewModel>(item.Id);
    //    }
    }
}