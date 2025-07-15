using SpikeDashboard.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SpikeDashboard.Pages;

public class IndexModel : PageModel
{

     public List<DashboardCardModel> Cards { get; set; }
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {


Cards = new List<DashboardCardModel>
        {
            new DashboardCardModel
            {
                title = "Total Users",
                value = 1204,
                change = 105.4,
                lastWeekChange = 100,
                isAvtive = true
            },
            new DashboardCardModel
            {
                title = "Active Subscriptions",
                value = 862,
                change = 97.9,
                lastWeekChange = 100,
                isAvtive = true
            },
            new DashboardCardModel
            {
                title = "New Signups",
                value = 120,
                change = 108.2,
                lastWeekChange = 100,
                isAvtive = false
            },
            new DashboardCardModel
            {
                title = "Chrun Rate",
                value = 4.3,
                change = 98.5,
                lastWeekChange = 100,
                valueType = "percentage",
                isAvtive = false
            }
        };
    }
}
