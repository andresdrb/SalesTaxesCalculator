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
    public static class TaxConfiguration
    {


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

        public static double GetImportsTaxRate()
        {


            return   SalesTaxesCalculator.Taxes.Default.ImportsTaxRate;
        }
       






    }
}