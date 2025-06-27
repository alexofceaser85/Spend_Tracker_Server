using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Server.Data.Enums;
using Server.Model;
using Server.Services;

namespace Server.Controllers;

[Route("api/spend")]
[ApiController]
public class SpendController : ControllerBase
{
    private readonly ISpendService spendService;
    
    public SpendController(ISpendService spendService)
    {
        this.spendService = spendService;    
    }
    
    [HttpGet]
    public IActionResult GetAllSpend()
    {
        var spends = this.spendService.GetAllSpend();
        return base.Ok(spends);
    }

    [HttpPost]
    public IActionResult AddSpend([FromForm] DateTime spendDate, [FromForm] string? location, [FromForm] double amount, [FromForm] SpendCategory category, [FromForm] Recurring recurring, [FromForm] string? notes)
    {
        var spend = new Spend(spendDate, location!, amount, category, recurring, notes!);
        var successful = spendService.AddSpend(spend);
        return successful ? Ok() : BadRequest();
    }
}