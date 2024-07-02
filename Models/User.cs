
namespace BettingApi.Models;

public class User {
    public Guid Userid {get; set;}
    required public string Username {get; set;}
    required public string PasswordHash {get; set;}
}
