using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesCalculator.Services.Printer
{
    public static class Printer
    {
        public static void PrintBasket(Basket.Basket basket)
        {
            foreach (var item in basket.Items)
            {
                Console.WriteLine("{0} {1}: {2}", item.Value.Count, item.Value.Item.ProductName, Math.Round(item.Value.Count * (item.Value.Item.ImportTaxes + item.Value.Item.VatTaxes + item.Value.Item.PriceSalesExclusive),2));
            }
            Console.WriteLine("Sales Taxes: {0}", basket.Taxes);
            Console.WriteLine("Total: {0}", basket.Taxes + basket.Subtotal);
            Console.WriteLine();
            Console.WriteLine();


        }
    }
}
