using Entities.Concrete;

namespace DataAccess.Abstracts;

public interface ICategoryDal
{
    void Add(Category category);
    void Delete(Category category);
    void Update(Category category);
    List<Category> GetAll();
    Category? GetById(int categoryId);
}
