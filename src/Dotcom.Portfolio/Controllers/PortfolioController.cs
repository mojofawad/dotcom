using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Dotcom.Portfolio.Controllers;

[ApiController]
[Route("dotcom/[controller]")]
public class PortfolioController(ILogger<PortfolioController> logger) : ControllerBase
{
    private readonly ILogger<PortfolioController> _logger = logger;

    [HttpGet(Name = "GetPortfolio")]
    public IEnumerable<PortfolioViewModel> Get()
    {
        return
        [
            new PortfolioViewModel
            {
                Name = "Portfolio 1",
                Description = "This is the first portfolio.",
                ImageUrl = "https://example.com/image1.jpg",
                Url = "https://example.com/portfolio1"
            },
            new PortfolioViewModel
            {
                Name = "Portfolio 2",
                Description = "This is the second portfolio.",
                ImageUrl = "https://example.com/image2.jpg",
                Url = "https://example.com/portfolio2"
            },
            new PortfolioViewModel
            {
                Name = "Portfolio 3",
                Description = "This is the third portfolio.",
                ImageUrl = "https://example.com/image3.jpg",
                Url = "https://example.com/portfolio3"
            }
        ];
    }
}

public class PortfolioViewModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public string Url { get; set; }
}