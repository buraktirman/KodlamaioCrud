using Entities.Concrete;

namespace DataAccess.Abstracts;

public interface ICourseDal
{
    void Add(Course course);
    void Delete(Course course);
    void Update(Course course);
    List<Course> GetAll();
    Course? GetById(int courseId);
}
