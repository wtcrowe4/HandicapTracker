using HandicapTracker.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HandicapTracker.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddScoreAsync(T score);
        Task AddScoreAsync(Score newScore);
        Task<IEnumerable<T>> GetScoresAsync(bool forceRefresh = false);

        //Task<bool> AddItemAsync(T item);

        //Task<bool> UpdateItemAsync(T item);

        //Task<bool> DeleteItemAsync(string id);

        //Task<T> GetItemAsync(string id);

        //Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
        //IEnumerable<T> GetItems(bool forceRefresh = false);
    }
}
