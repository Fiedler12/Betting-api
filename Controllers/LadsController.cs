
using BettingApi.Models;
using Microsoft.AspNetCore.Mvc;


namespace BettingApi.Controllers;

[Route("api/[controller]")]
public class LadsController: MyControllerBase {

    private readonly ILogger<LadsController> _logger;

    public LadsController(ILogger<LadsController> logger) {
        _logger = logger;
    }

    [HttpGet]
    [Produces("application/json")]
    public IActionResult GetLads() {
        var user = new User {
            Userid = new Guid(),
            Username = "Oer cool",
            PasswordHash = "gjgjg"
        };
        var lad = new Lad {
            id = new Guid(),
            Name = "Daniel Ottosen",
            Nickname = "O",
            User = user,
            SlapsOwed = null,
            SlapsToAdminister = null
        };

        return Ok(lad);
    }

    [HttpGet("/{id}")]
    public IActionResult GetSpecificLad(string id) {
        return Ok();
    }

    
}
