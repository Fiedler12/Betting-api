
namespace BettingApi.Models;

public class Bet {
    public Guid Id {get; set;}
    public int Amount {get; set;}
    public BettingType bettingType {get; set;}
    required public User UserThatCreated {get; set;}
    required public User UserToAccept {get; set;}
    required public bool IsAccepted {get; set;}
    required public bool IsConcluded {get; set;}
    public User? Winner {get; set;}
}
