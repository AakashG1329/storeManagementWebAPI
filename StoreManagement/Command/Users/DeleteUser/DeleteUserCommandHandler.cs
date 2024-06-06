using MediatR;
using StoreManagement.Models;
using StoreManagement.ResponceModel.Users;

namespace StoreManagement.Command.Users.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, DeleteUserResponceModel>
    {
        private readonly StoreDbContext _dbContext;
        public DeleteUserCommandHandler( StoreDbContext dbContext)
        {
          _dbContext=dbContext;
        }
        public async Task<DeleteUserResponceModel> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            DeleteUserResponceModel data = new DeleteUserResponceModel();
            if(request.id ==null || request.id <= 0)
            {
                data.message = "User Id is required";
                data.status = "404";
                return data;
            }
            try
            {
                var user = _dbContext.users.FirstOrDefault(x => x.id == request.id);
                if (user == null)
                {
                    data.message = "User Id Not Found";
                    data.status = "404";
                    return data;
                }
                _dbContext.users.Remove(user);
                _dbContext.SaveChanges();

                data.message = "User Detailes Deleted Successfully";
                data.status = "200";
                return data;
            }
            catch (Exception)
            {

                data.message = "User Detailes Delete Failed";
                data.status = "204";
                return data;
            }
        }
    }
}
