using Business.Abstract;
using DataAccess.Abstracts;
using Entities.Concrete;

namespace Business.Concrete;

public class InstructorManager : IInstructorService
{
    private IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public void Add(Instructor instructor)
    {
        _instructorDal.Add(instructor);
    }

    public void Delete(Instructor instructor)
    {
        _instructorDal.Delete(instructor);
    }

    public List<Instructor> GetAll()
    {
        return _instructorDal.GetAll();
    }

    public Instructor? GetById(int instructorId)
    {
        return _instructorDal.GetById(instructorId);
    }

    public void Update(Instructor instructor)
    {
        _instructorDal.Update(instructor);
    }
}
