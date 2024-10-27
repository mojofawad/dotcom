using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Dotcom.Engagement.Controllers;

[ApiController]
[Route("dotcom/[controller]")]
public class EngagementController(ILogger<EngagementController> logger) : ControllerBase
{

    private readonly ILogger<EngagementController> _logger = logger;

    [HttpGet(Name = "GetEngagement")]
    public IEnumerable<EngagementData> Get()
    {
        return
        [
            new EngagementData("Likes", 100, "The number of likes on the page."),
            new EngagementData("Comments", 50, "The number of comments on the page."),
            new EngagementData("Shares", 1, "The number of shares on the page.")
        ];
    }
}

public class EngagementData(string name, int value, string description)
{
    public string Name { get; set; } = name;
    public int Value { get; set; } = value;
    public string Description { get; set; } = description;
}