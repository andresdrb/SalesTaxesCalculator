using System.Configuration;
using System.Collections.Specialized;

namespace SalesTaxesCalculator.Services.Taxes
{

     public enum VATType
        {
            
            Exempt,
            Reduced,
            Basic
        }

    /// <summary>
    /// Manages Taxes configuration
    /// </summary>
    public static class TaxConfiguration
    {

        /// <summary>
        /// Get the configuration value for a given tax rate
        /// </summary>
        /// <param name="vatType">The tax rate to retrieve the configuration for</param>
        /// <returns></returns>
        public static double GetVATTaxRate(VATType vatType)
        {


            switch (vatType)
            {
                case VATType.Exempt:
                    return SalesTaxesCalculator.Taxes.Default.ExemptTaxRate;
                   
                case VATType.Reduced:
                    break;
                case VATType.Basic:
                    return SalesTaxesCalculator.Taxes.Default.BasicTaxRate;

            }

            return 0;
        }


        /// <summary>
        /// Retrieves the Imports Tax rate configuration
        /// </summary>
        /// <returns></returns>
        public static double GetImportsTaxRate()
        {


            return   SalesTaxesCalculator.Taxes.Default.ImportsTaxRate;
        }
       






    }
}