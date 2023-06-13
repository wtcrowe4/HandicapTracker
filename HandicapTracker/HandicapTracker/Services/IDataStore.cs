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

        //Task<bool> UpdateItemAsync(T item);

        //Task<bool> DeleteItemAsync(string id);

        //Task<T> GetItemAsync(string id);

        //Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
        //IEnumerable<T> GetItems(bool forceRefresh = false);
    }
}
