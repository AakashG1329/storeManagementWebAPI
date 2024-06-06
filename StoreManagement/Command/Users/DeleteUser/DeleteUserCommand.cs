using MediatR;
using StoreManagement.ResponceModel.Users;

namespace StoreManagement.Command.Users.DeleteUser
{
    public class DeleteUserCommand :IRequest<DeleteUserResponceModel>
    {
        public int id { get; set; }
    }
}
