using DataAccess.Abstracts;
using Entities.Concrete;

namespace DataAccess.Concretes;

public class CategoryDal : ICategoryDal
{
    List<Category> _categories;
    public CategoryDal()
    {
        Category category1 = new Category { Id = 1, Name = "Programming" };
        Category category2 = new Category { Id = 2, Name = "Language" };

        _categories = new List<Category> { category1, category2 };
    }
    public void Add(Category category)
    {
        _categories.Add(category);
    }

    public void Delete(Category category)
    {
        var categoryToDelete = _categories.FirstOrDefault(c => c.Id == category.Id);

        if (categoryToDelete != null)
        {
            _categories.Remove(categoryToDelete);
        }
    }

    public List<Category> GetAll()
    {
        return _categories;
    }

    public Category? GetById(int categoryId)
    {
        return _categories.FirstOrDefault(c => c.Id == categoryId);
    }

    public void Update(Category category)
    {
        var categoryToUpdate = _categories.FirstOrDefault(c => c.Id == category.Id);

        if (categoryToUpdate != null)
        {
            categoryToUpdate.Name = category.Name;
        }
    }
}
