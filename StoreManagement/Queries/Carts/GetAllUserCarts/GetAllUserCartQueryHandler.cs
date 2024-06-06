using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StoreManagement.Models;
using StoreManagement.ResponceModel.Carts;
using StoreManagement.ResponceModel.Users;
using static StoreManagement.ResponceModel.Carts.GetAllCartListResponceModel;

namespace StoreManagement.Queries.Carts.GetAllUserCarts
{
    public class GetAllUserCartQueryHandler : IRequestHandler<GetAllUserCartQuery, GetAllCartListResponceModel>
    {
        private readonly StoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetAllUserCartQueryHandler(StoreDbContext dbContext, IMapper mapper)
        {
            _dbContext=dbContext;
            _mapper=mapper;
        }
        public async Task<GetAllCartListResponceModel> Handle(GetAllUserCartQuery request, CancellationToken cancellationToken)
        {
            GetAllCartListResponceModel cartData = new GetAllCartListResponceModel();
            var datas = new List<GetCartModel>();
            if ( request.userId <= 0)
            {
                cartData.message = "Invalid UserId!";
                cartData.status = "204";
                cartData.cartData = null;
                return cartData;
            }
            var user = _dbContext.users.FirstOrDefault(x => x.id == request.userId);
            if(user == null)
            {
                cartData.message = "User Details Not Found";
                cartData.status = "204";
                cartData.cartData = null;
                return cartData;
            }
            if (user.role_id !=3)
            {
                cartData.message = "You Don't Have Access Please Contact Admin";
                cartData.status = "204";
                cartData.cartData = null;
                return cartData;
            }var query = string.Format("EXEC GetAllUsersCarts");

            var carts =  _dbContext.carts.FromSqlRaw("EXECUTE GetAllUsersCarts").ToList();
            if(carts.Count <= 0)
            {
                cartData.message = "Carts Details Not Found!";
                cartData.status = "204";
                cartData.cartData = datas;
                return cartData;
            }
            foreach(var item in carts)
            {
                GetCartModel data=new GetCartModel();
                data.id = item.id;
                datas.Add(data);
            }
            cartData.message = "Carts Details Fetched Successfully!";
            cartData.status = "200";
            cartData.cartData = datas;
            return cartData;
        }
    }
}
