using MediatR;
using StoreManagement.Models;
using StoreManagement.ResponceModel.Users;
using System.Data;
using static StoreManagement.ResponceModel.Users.PostUserResponceModel;

namespace StoreManagement.Command.Users.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, PostUserResponceModel>
    {
        private readonly IMediator _mediator;
        private readonly StoreDbContext _dbContext;
        public UpdateUserCommandHandler(StoreDbContext dbContext, IMediator mediator)
        {
            _mediator = mediator;
            _dbContext = dbContext;
        }
        public async Task<PostUserResponceModel> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            PostUserResponceModel userData = new PostUserResponceModel();
            if (request.id == null || request.id <= 0)
            {
                userData.message = "user_id is required!";
                userData.status = "404";
                userData.UserData = null;
                return userData;
            }
            try
            {
                var user = _dbContext.users.FirstOrDefault(x => x.id == request.id);
                if (user == null)
                {
                    userData.message = "User " + request.id + " Id Not Found!";
                    userData.status = "404";
                    userData.UserData = null;
                    return userData;
                }
                user.name = request.name;
                user.email = request.email;
                user.phone_number = request.phone_number;
                _dbContext.SaveChanges();
                var datas = new UserModel
                {
                    id = user.id,
                    name = user.name,
                    username = user.username,
                    email = user.email,
                    phone_number = user.phone_number,
                    is_active = user.is_active,
                    role_id = user.role_id,
                };

                userData.message = "User Details Updated Successfully!";
                userData.status = "200";
                userData.UserData = datas;
                return userData;
            }
            catch (Exception)
            {

                userData.message = "User Details Update Failed!";
                userData.status = "400";
                userData.UserData = null;
                return userData;
            }
        }
    }
}
