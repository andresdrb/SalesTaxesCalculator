using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesTaxesCalculator.Services.Products;
using SalesTaxesCalculator.Services.Taxes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesCalculator.Services.Taxes.Tests
{
    [TestClass()]
    public class TaxConfigurationTests
    {
        [TestMethod()]
        public void GetBasicVATTaxRateTest()
        {
            double taxRate;
            taxRate =Taxes.TaxConfiguration.GetVATTaxRate(VATType.Basic);
            Assert.IsTrue(taxRate == 10);
        }

        [TestMethod()]
        public void GetExemptVATTaxRateTest()
        {
            double taxRate;
            taxRate = Taxes.TaxConfiguration.GetVATTaxRate(VATType.Exempt);
            Assert.IsTrue(taxRate == 0);
        }

        [TestMethod()]
        public void GetReducedVATTaxRateTest()
        {
            double taxRate;
            taxRate = Taxes.TaxConfiguration.GetVATTaxRate(VATType.Reduced);
            Assert.IsTrue(taxRate == 0);
        }

        [TestMethod()]
        public void GetImportsTaxRateTest()
        {
            double taxRate;
            taxRate = Taxes.TaxConfiguration.GetImportsTaxRate();
            Assert.IsTrue(taxRate == 5);
        }
    }
}