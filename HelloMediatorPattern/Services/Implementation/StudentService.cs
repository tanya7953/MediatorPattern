using HelloMediatorPattern.Services.Interface;
using HelloMediatorPattern.ViewModels.Request;

namespace HelloMediatorPattern.Services.Implementation
{
    public class StudentService : IStudentService
    {
        public string AddStudent(StudentViewModel studentViewModel)
        {
            //student record saved
            Console.WriteLine("student record saved");
            return "SAved Successully";
        }
    }
}
