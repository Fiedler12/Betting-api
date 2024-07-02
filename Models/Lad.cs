
namespace BettingApi.Models; 

public class Lad {
    public Guid id {get; set;}
    required public string Name {get; set;}
    public string? Nickname {get; set;}
    public virtual required User User {get; set;}
    public Dictionary<Lad, int>? SlapsOwed {get; set;}
    public Dictionary<Lad, int>? SlapsToAdminister {get; set;}
}