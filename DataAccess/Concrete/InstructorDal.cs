using DataAccess.Abstracts;
using Entities.Concrete;

namespace DataAccess.Concretes;

public class InstructorDal : IInstructorDal
{
    List<Instructor> _instructors;
    public InstructorDal()
    {
        Instructor instructor1 = new Instructor
        {
            Id = 1,
            FirstName = "Engin",
            LastName = "Demiroğ"
        };

        Instructor instructor2 = new Instructor
        {
            Id = 2,
            FirstName = "Halit Enes",
            LastName = "Kalaycı"
        };

        _instructors = new List<Instructor> { instructor1, instructor2 };
    }
    public void Add(Instructor instructor)
    {
        _instructors.Add(instructor);
    }

    public void Delete(Instructor instructor)
    {
        var instructorToDelete = _instructors.FirstOrDefault(i => i.Id == instructor.Id);

        if (instructorToDelete != null)
        {
            _instructors.Remove(instructorToDelete);
        }
    }

    public List<Instructor> GetAll()
    {
        return _instructors;
    }

    public Instructor? GetById(int instructorId)
    {
        return _instructors.FirstOrDefault(i => i.Id == instructorId);
    }

    public void Update(Instructor instructor)
    {
        var instructorToUpdate = _instructors.FirstOrDefault(i => i.Id == instructor.Id);

        if (instructorToUpdate != null)
        {
            instructorToUpdate.FirstName = instructor.FirstName;
            instructorToUpdate.LastName = instructor.LastName;
        }
    }
}
