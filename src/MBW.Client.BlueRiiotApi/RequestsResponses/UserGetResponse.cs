using MBW.Client.BlueRiiotApi.Objects;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.RequestsResponses
{
    public class UserGetResponse
    {
        [JsonProperty("userInfo")]
        public UserInfo UserInfo { get; set; }
        
        [JsonProperty("userPreferences")]
        public UserPreferences UserPreferences { get; set; }
        
        [JsonProperty("currentEula")]
        public Eula CurrentEula { get; set; }
        
        [JsonProperty("userModuleAccess")]
        public UserModuleAccess UserModuleAccess { get; set; }
    }
}