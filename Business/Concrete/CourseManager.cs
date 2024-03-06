using Business.Abstract;
using DataAccess.Abstracts;
using Entities.Concrete;

namespace Business.Concrete;

public class CourseManager : ICourseService
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Delete(Course course)
    {
        _courseDal.Delete(course);
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public Course? GetById(int courseId)
    {
        return _courseDal.GetById(courseId);
    }

    public void Update(Course course)
    {
        _courseDal.Update(course);
    }
}
