using HelloMediatorPattern.ViewModels.Request;
using HelloMediatorPattern.ViewModels.Response;
using MediatR;

namespace HelloMediatorPattern.Handler
{
    public class StudentRequest : StudentViewModel, IRequest<ResponseStudentViewModel>
    {

    }
}
