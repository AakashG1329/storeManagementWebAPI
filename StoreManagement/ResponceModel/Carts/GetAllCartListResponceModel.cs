using StoreManagement.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagement.ResponceModel.Carts
{
    public class GetAllCartListResponceModel
    {
        public string status { get; set; }
        public string message { get; set; }
        public List<GetCartModel> cartData { get; set; }
        public GetAllCartListResponceModel()
        {

            cartData = new List<GetCartModel>();
           
        }
        public class GetCartModel
        {
            public int id { get; set; }
            public bool notification { get; set; }
            public bool is_add_to_cart { get; set; }
            public int quantity { get; set; }
            public int totall_price { get; set; }
            public GetProduct productData { get; set; }
            public GetSeller sellerData { get; set; }
         
            public GetCartModel()
            {
                productData = new GetProduct();
                sellerData = new GetSeller();
            }
            public class GetProduct
            {
                public int id { get; set; }
                public string item_number { get; set; }
                public string product_name { get; set; }
                public string description { get; set; }
                public int price { get; set; }
                public string img_url { get; set; }
                public int cat_code { get; set; }
                public string? cat_name { get; set; }
            }
            public class GetSeller
            {
                public int id { get; set; }
                public string? name { get; set; }
                public string? username { get; set; }
                public string? email { get; set; }
                public string? phone_number { get; set; } = string.Empty;
            }
        }
    }
}
