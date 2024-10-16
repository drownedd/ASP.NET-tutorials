using api.Dtos.Stock;
using api.Helpers;
using api.Models;

namespace api.Interfaces
{
    public interface IStockRepository
    {

        Task<List<Stock>> GetAllAsync(Query query);
        Task<Stock?> GetByIdAsync(int id);
        Task<Stock> CreateAsync(Stock stock);
        Task<Stock?> UpdateAsync(int id, UpdateStockDto stockDto);
        Task<Stock?> DeleteAsync(int id);
        Task<bool> Exists(int id);

    }
}