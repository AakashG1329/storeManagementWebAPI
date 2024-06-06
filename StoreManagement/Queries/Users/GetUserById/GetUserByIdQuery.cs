using MediatR;
using StoreManagement.ResponceModel.Users;

namespace StoreManagement.Queries.Users.GetUserById
{
    public class GetUserByIdQuery :IRequest<GetUserResponceModel>
    {
        public int id { get; set; }
    }
}
