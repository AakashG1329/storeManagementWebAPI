namespace StoreManagement.ResponceModel.Users
{
    public class GetUserListResponceModel
    {
        public string status { get; set; }
        public string message { get; set; }
        public List<GetUserModel> UserData { get; set; }
        public GetUserListResponceModel()
        {

            UserData = new List<GetUserModel>();
        }
        public class GetUserModel
        {
            public int id { get; set; }
            public string? name { get; set; }
            public string? username { get; set; }
            public string? email { get; set; }
            public string? phone_number { get; set; } = string.Empty;
            public bool is_active { get; set; }
            public int role_id { get; set; }
        }

    }


}
