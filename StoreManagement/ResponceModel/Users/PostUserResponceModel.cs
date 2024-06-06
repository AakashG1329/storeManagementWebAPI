namespace StoreManagement.ResponceModel.Users
{
    public class PostUserResponceModel
    {
        public string status { get; set; }
        public string message { get; set; }
        public UserModel UserData { get; set; }
        public PostUserResponceModel() {

            UserData = new UserModel();
                }
        public class UserModel
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
