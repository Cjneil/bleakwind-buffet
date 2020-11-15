/*
 * Author: Connor Neil 
 * File: Index.cshtml.cs
 * Purpose: Functions as model for information needed in Index.cshtml along with handling Get requests for the site
 */

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
        public void OnGet(int? CaloriesMin, int? CaloriesMax, double? PriceMin, double? PriceMax)
        {
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
            SearchTerms = Request.Query["SearchTerms"];
            OrderItemTypes = Request.Query["OrderItemTypes"];
            OrderItems = Menu.FullMenu();
            OrderItems = Menu.FilterByItemTypes(OrderItems, OrderItemTypes);
            OrderItems = Menu.FilterByCalories(OrderItems, CaloriesMin, CaloriesMax);
            OrderItems = Menu.FilterByPrice(OrderItems, PriceMin, PriceMax);

            if (SearchTerms != null)
            {
                string[] splitTerms = SearchTerms.Split(" ");
                //this is here because for some reason the Data project does not seem to recognize the Contains(2 inputs) overload despite necessary dependencies
                OrderItems = OrderItems.Where(item => splitTerms.Any(term => item.Name.Contains(term, StringComparison.InvariantCultureIgnoreCase)) || splitTerms.Any(term => item.Description.Contains(term, StringComparison.InvariantCultureIgnoreCase)));
            }
        }
    }
}
