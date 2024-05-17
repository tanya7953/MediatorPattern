using HelloMediatorPattern.ViewModels.Request;

namespace HelloMediatorPattern.Services.Interface
{
    public interface IStudentService
    {
        string AddStudent(StudentViewModel studentViewModel);
    }
}
