using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class UserInfo
    {
        [JsonProperty("userIdentityId")]
        public string UserIdentityId { get; set; }
        
        [JsonProperty("userId")]
        public string UserId { get; set; }
        
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        
        [JsonProperty("email")]
        public string Email { get; set; }
        
        [JsonProperty("accepted_last_eula")]
        public bool AcceptedLastEula { get; set; }
        
        [JsonProperty("account_type")]
        public string AccountType { get; set; }
    }
}