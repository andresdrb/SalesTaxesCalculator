using SalesTaxesCalculator.Services.Basket;
using SalesTaxesCalculator.Services.Products;
using System;

namespace SalesTaxesCalculator.Services.Taxes
{

    public static class TaxCalculator
    {

        public static double CalculateItemVAT(Product item)
        {

            double vat = 0;

            vat = (item.PriceSalesExclusive * Taxes.TaxConfiguration.GetVATTaxRate(item.TaxVATTypeId))/100;
            return RoundTaxes(vat);
        }

        public static double CalculateItemImportTax(Product item)
        {
            double importTax = 0;
            if (item.Imported)
            {
                importTax = (item.PriceSalesExclusive * Taxes.TaxConfiguration.GetImportsTaxRate()) / 100;

            }
            
            return RoundTaxes(importTax);

        }

      
        internal static double RoundTaxes(double taxes)
        {

                var ceiling = Math.Ceiling(taxes * 20);
                if (ceiling == 0)
                {
                    return 0;
                }
                return ceiling / 20;
            }


    }
}