using SalesTaxesCalculator.Services.Basket;
using SalesTaxesCalculator.Services.Products;
using System;

namespace SalesTaxesCalculator.Services.Taxes
{
    /// <summary>
    /// Class that implemets all the logic required to calculate taxes
    /// </summary>
    public static class TaxCalculator
    {
        /// <summary>
        /// Calculates the VAT tax that a given product is charged with
        /// </summary>
        /// <param name="item">Product to calculate the tax for</param>
        /// <returns></returns>
        public static double CalculateItemVAT(Product item)
        {
            try
            {

                double vat = 0;

                vat = (item.PriceSalesExclusive * Taxes.TaxConfiguration.GetVATTaxRate(item.TaxVATTypeId)) / 100;
                return RoundTaxes(vat);
            }
            catch (Exception ex)
            {
                //TODO: Implement logging
                throw;
            }
        }


        /// <summary>
        /// Calculates the imports tax that a given product is charged with
        /// </summary>
        /// <param name="item">Product to calculate the tax for</param>
        /// <returns></returns>
        public static double CalculateItemImportTax(Product item)
        {
            try
            {
                double importTax = 0;
                if (item.Imported)
                {
                    importTax = (item.PriceSalesExclusive * Taxes.TaxConfiguration.GetImportsTaxRate()) / 100;

                }

                return RoundTaxes(importTax);
            }
            catch (Exception ex)
            {
                //TODO: Implement logging
                throw;
            }

        }

        /// <summary>
        /// Round taxes value as to the nearest upper 0.05 value
        /// </summary>
        /// <param name="taxes">Value to be rounded</param>
        /// <returns></returns>
        internal static double RoundTaxes(double taxes)
        {
            try
            {

                var ceiling = Math.Ceiling(taxes * 20);
                if (ceiling == 0)
                {
                    return 0;
                }
                return Math.Round(ceiling / 20, 2);
            }
            catch (Exception ex)
            {
                //TODO: Implement logging
                throw;
            }
         }


    }
}