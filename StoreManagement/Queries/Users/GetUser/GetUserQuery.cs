using MediatR;
using StoreManagement.ResponceModel.Users;

namespace StoreManagement.Queries.Users.GetUser
{
    public class GetUserQuery :IRequest<GetUserListResponceModel>
    {
    }
}
