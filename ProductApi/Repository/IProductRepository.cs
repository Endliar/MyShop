using ProductApi.Models.ProductDto;

namespace ProductApi.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts(); // получение списка всех товаров
        Task<ProductDto> GetProductById(int productId); // получение ссылки на один из товаров по id
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto); // создание или обновление существующих товаров
        Task<bool> DeleteProduct(int productId); // удаление товара
    }
}