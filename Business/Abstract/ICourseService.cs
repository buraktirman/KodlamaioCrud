using Entities.Concrete;

namespace Business.Abstract;

public interface ICourseService
{
    void Add(Course course);
    void Delete(Course course);
    void Update(Course course);
    List<Course> GetAll();
    Course? GetById(int courseId);
}
