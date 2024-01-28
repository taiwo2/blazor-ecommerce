namespace Blazor_Ecommerce.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        event Action OnChange;
        List<Category> Categories { get; set; }
        Task GetCategories();
       
    }
}