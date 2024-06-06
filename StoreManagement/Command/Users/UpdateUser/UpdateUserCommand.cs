using MediatR;
using StoreManagement.ResponceModel.Users;

namespace StoreManagement.Command.Users.UpdateUser
{
    public class UpdateUserCommand :IRequest<PostUserResponceModel>
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? email { get; set; }
        public string? phone_number { get; set; } = string.Empty;
    }
}
