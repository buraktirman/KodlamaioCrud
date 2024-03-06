using Entities.Concrete;

namespace Business.Abstract;

public interface IInstructorService
{
    void Add(Instructor instructor);
    void Delete(Instructor instructor);
    void Update(Instructor instructor);
    List<Instructor> GetAll();
    Instructor? GetById(int instructorId);
}
