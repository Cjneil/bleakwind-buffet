using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// minimum calories to show
        /// </summary>
        public int? CaloriesMin { get; set; }
        /// <summary>
        /// max calories for any items shown
        /// </summary>
        public int? CaloriesMax { get; set; }

        /// <summary>
        /// minimum price of items shown
        /// </summary>
        public double? PriceMin { get; set; }
        /// <summary>
        /// maximum price of items shown
        /// </summary>
        public double? PriceMax { get; set; }

        /// <summary>
        /// types of items to show
        /// </summary>
        public string[] OrderItemTypes { get; set; } = { "Entrees", "Sides", "Drinks"};
        
        /// <summary>
        /// Items to show
        /// </summary>
        public IEnumerable<IOrderItem> OrderItems { get; protected set; }

        /// <summary>
        /// Terms to show items that include
        /// </summary>
        public string SearchTerms { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// handles query information on get request to filter menu items
        /// </summary>
        public void OnGet()
        {
            CaloriesMin = int.TryParse(Request.Query["CaloriesMin"], out var i) ? i : default(int?);
            CaloriesMax = int.TryParse(Request.Query["CaloriesMax"], out var j) ? j : default(int?);
            PriceMin = double.TryParse(Request.Query["PriceMin"], out var k) ? k : default(double?);
            PriceMax = double.TryParse(Request.Query["PriceMax"], out var l) ? l : default(double?);
            SearchTerms = Request.Query["SearchTerms"];
            OrderItemTypes = Request.Query["OrderItemTypes"];
            OrderItems = Menu.Search(SearchTerms);
            OrderItems = Menu.FilterByItemTypes(OrderItems, OrderItemTypes);
            OrderItems = Menu.FilterByCalories(OrderItems, CaloriesMin, CaloriesMax);
            OrderItems = Menu.FilterByPrice(OrderItems, PriceMin, PriceMax);
        }
    }
}
