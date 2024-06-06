using AutoMapper;
using MediatR;
using StoreManagement.Models;
using StoreManagement.ResponceModel.Users;
using System.Data;
using static StoreManagement.ResponceModel.Users.GetUserResponceModel;
using static StoreManagement.ResponceModel.Users.PostUserResponceModel;

namespace StoreManagement.Queries.Users.GetUserById
{
    public class GetUserQueryHandler : IRequestHandler<GetUserByIdQuery, GetUserResponceModel>
    {
        private readonly StoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetUserQueryHandler(StoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;


        }
        public async Task<GetUserResponceModel> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            GetUserResponceModel userData = new GetUserResponceModel();
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

                var datas = new GetUserModel
                {
                    id = user.id,
                    name = user.name,
                    username = user.username,
                    email = user.email,
                    phone_number = user.phone_number,
                    is_active = user.is_active,
                    role_id = user.role_id,
                };

                userData.message = "User Details Fetched Successfully!";
                userData.status = "200";
                userData.UserData = datas;
                return userData;
            }
            catch (Exception)
            {
                userData.message = "User Details Failed to Fetched!";
                userData.status = "404";
                userData.UserData = null;
                return userData;
            }
        }
    }
}
