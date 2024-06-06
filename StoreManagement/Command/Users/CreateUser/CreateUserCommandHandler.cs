using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StoreManagement.Models;
using StoreManagement.ResponceModel.Users;
using static StoreManagement.ResponceModel.Users.PostUserResponceModel;

namespace StoreManagement.Command.Users.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, PostUserResponceModel>
    {
        private readonly StoreDbContext _dbContext;
        private IMapper _mapper;
        public CreateUserCommandHandler(StoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;

    }
        public async Task<PostUserResponceModel> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            PostUserResponceModel userData = new PostUserResponceModel();
            if(request.role_id==null || request.role_id <= 0)
            {
                userData.message = "role_id is required!";
                userData.status = "404";
                userData.UserData = null;
                return userData;

            }
            try
            {
                var getRole=  _dbContext.roles.FirstOrDefault(x => x.id == request.role_id);
                if (getRole == null)
                {
                    userData.message = "Invalid role_id!";
                    userData.status = "404";
                    userData.UserData = null;
                    return userData;
                }
                var getUser =  _dbContext.users.FirstOrDefault(x => x.email == request.email);
                if (getUser != null)
                {
                    userData.message = "User Email Already Found!";
                    userData.status = "404";
                    userData.UserData = null;
                    return userData;
                }

                var user =  _mapper.Map<User>(request);
           
                user.status = true;
                user.is_active = true;
                user.created_date = DateTime.UtcNow;
                await _dbContext.users.AddAsync(user);
                _dbContext.SaveChanges();
                userData.message = "User Created Successfully!";
                userData.status = "200" ;
                var datas = new UserModel
                {
                    id=user.id,
                    name = user.name,
                    username = user.username,
                    email = user.email,
                    phone_number = user.phone_number,
                    is_active = user.is_active,
                    role_id = user.role_id,
                    
                };
                userData.UserData = datas;
            }
            catch (Exception ex)
            {
                
                userData.message = ex.ToString();
                userData.status = "400";
                userData.UserData = null;
                return userData;
            }
            return userData;
        }
    }
}
