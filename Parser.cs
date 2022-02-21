using AngleSharp;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetPraceEth
{
    class Parser
    {
        private IConfiguration config = Configuration.Default.WithDefaultLoader();
        private string address = "https://coinmarketcap.com/currencies/bitcoin/markets/";

        public List<string> Parse()
        {
            using (var document = BrowsingContext.New(config).OpenAsync(address))
            {
                var parsedHtml = document.Result;
                var priceEth = parsedHtml.All.Where(m => m.ClassList.Contains("priceValue"));

                var list = new List<string>();

                foreach (var item in priceEth)
                {
                    list.Add(item.TextContent);
                }

                return list;
            }
        }
    }
}
