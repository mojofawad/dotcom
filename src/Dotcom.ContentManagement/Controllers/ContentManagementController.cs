using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Dotcom.ContentManagement.Controllers;

[ApiController]
[Route("dotcom/[controller]")]
public class ContentManagementController(ILogger<ContentManagementController> logger) : ControllerBase
{
    private readonly ILogger<ContentManagementController> _logger = logger;

    [HttpGet(Name = "GetContent")]
    public IEnumerable<Content> Get()
    {
        return
        [
            new Content("Hello, world!", "Welcome to Dotcom!", "Alice"),
            new Content("Hello, world!", "Welcome to Dotcom!", "Bob"),
            new Content("Hello, world!", "Welcome to Dotcom!", "Charlie")
        ];
    }
}

public class Content(string title, string body, string author)
{
    public string Title { get; set; } = title;
    public string Body { get; set; } = body;
    public string Author { get; set; } = author;
}