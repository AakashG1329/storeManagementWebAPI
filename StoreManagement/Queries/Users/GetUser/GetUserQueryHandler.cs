using AutoMapper;
using MediatR;
using StoreManagement.Models;
using StoreManagement.ResponceModel.Users;
using static StoreManagement.ResponceModel.Users.GetUserListResponceModel;

namespace StoreManagement.Queries.Users.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, GetUserListResponceModel>
    {
        private readonly StoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetUserQueryHandler(StoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<GetUserListResponceModel> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            GetUserListResponceModel userData = new GetUserListResponceModel();
            var datas = new List<GetUserModel>();
            try
            {
                var users = _dbContext.users.ToList();
                if (users.Count <=0)
                {
                    userData.message = "Users Not Found!";
                    userData.status = "404";
                    userData.UserData = datas;
                    return userData;
                }
                foreach (var item in users)
                {
                    GetUserModel data = new GetUserModel();
                    data.id = item.id;
                    data.name = item.name;
                    data.username = item.username;
                    data.email = item.email;
                    data.phone_number = item.phone_number;
                    data.role_id = item.role_id;
                    datas.Add(data);
                }
                userData.message = "Users Details Fetched Successfully!";
                userData.status = "200";
                userData.UserData = datas;
                return userData;
            }
            catch (Exception)
            {

                userData.message = "Users Details Failed to Fetched!";
                userData.status = "204";
                userData.UserData = null;
                return userData;
            }
        }
    }
}
