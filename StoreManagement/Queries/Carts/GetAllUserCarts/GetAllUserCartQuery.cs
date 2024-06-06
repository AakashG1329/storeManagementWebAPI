using MediatR;
using StoreManagement.ResponceModel.Carts;

namespace StoreManagement.Queries.Carts.GetAllUserCarts
{
    public class GetAllUserCartQuery :IRequest<GetAllCartListResponceModel>
    {
        public int userId { get; set; } 
    }
}
