﻿using Business.Abstract;
using DataAccess.Abstracts;
using Entities.Concrete;

namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public void Delete(Category category)
    {
        _categoryDal.Delete(category);
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public Category? GetById(int categoryId)
    {
        return _categoryDal.GetById(categoryId);
    }

    public void Update(Category category)
    {
        _categoryDal.Update(category);
    }
}
