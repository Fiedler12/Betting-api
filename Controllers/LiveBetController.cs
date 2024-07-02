
using Microsoft.AspNetCore.Mvc;

namespace BettingApi.Controllers; 

[Route("api/[controller]")]
public class LiveBetController : MyControllerBase {


    private readonly ILogger<LiveBetController> _logger; 

    public LiveBetController(ILogger<LiveBetController> logger) {
        _logger = logger;
    }    

    [HttpGet]
    public ActionResult getOk() {
        return Ok();
    }

}