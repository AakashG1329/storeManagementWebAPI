using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MediatR;
using StoreManagement.Models;
using StoreManagement.ResponceModel.Users;

namespace StoreManagement.Command.Users.CreateUser
{
    public class CreateUserCommand:IRequest<PostUserResponceModel>
    {
        public string? name { get; set; }
        public string? username { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }
        public string? phone_number { get; set; } = string.Empty;
        public int role_id { get; set; }
    }
}
