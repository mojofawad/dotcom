using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Dotcom.Analytics.Controllers;

[ApiController]
[Route("dotcom/[controller]")]
public class Analytics(ILogger<Analytics> logger) : ControllerBase
{
    private readonly ILogger<Analytics> _logger = logger;

    [HttpGet(Name = "GetAnalytics")]
    public IEnumerable<AnalyticsData> Get()
    {
        return
        [
            new AnalyticsData("PageViews", 100),
            new AnalyticsData("UniqueVisitors", 50),
            new AnalyticsData("BounceRate", 1)
        ];
    }
}

public class AnalyticsData(string name, int value)
{
    public string Name { get; set; } = name;
    public int Value { get; set; } = value;
}