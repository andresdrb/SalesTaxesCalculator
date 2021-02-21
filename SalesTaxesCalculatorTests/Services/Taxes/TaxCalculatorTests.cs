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
    public class TaxCalculatorTests
    {
        

        [TestMethod()]
        public void CalculateItemVATBasicRoundLowTest()
        {
            Assert.IsTrue(Taxes.TaxCalculator.CalculateItemVAT(new Products.Product(1,"Test",12.03,VATType.Basic,false))==1.25);
        }

        [TestMethod()]
        public void CalculateItemVATBasicRoundExactTest()
        {
            Assert.IsTrue(Taxes.TaxCalculator.CalculateItemVAT(new Products.Product(1, "Test", 12, VATType.Basic, false)) == 1.2);
        }

        [TestMethod()]
        public void CalculateItemVATBasicRoundHighTest()
        {
            Assert.IsTrue(Taxes.TaxCalculator.CalculateItemVAT(new Products.Product(1, "Test", 12.6, VATType.Basic, false)) == 1.30);
        }


        [TestMethod()]
        public void CalculateItemImportTaxRoundLowTest()
        {
            Assert.IsTrue(Taxes.TaxCalculator.CalculateItemImportTax(new Products.Product(1, "Test", 12.03, VATType.Basic, true)) == 0.65);
        }

        [TestMethod()]
        public void CalculateItemImportTaxRoundExactTest()
        {
            Assert.IsTrue(Taxes.TaxCalculator.CalculateItemImportTax(new Products.Product(1, "Test", 12, VATType.Basic, true)) ==0.6);
        }

        [TestMethod()]
        public void CalculateItemImportTaxRoundHighTest()
        {
            Assert.IsTrue(Taxes.TaxCalculator.CalculateItemImportTax(new Products.Product(1, "Test", 13.2, VATType.Basic, true)) == 0.7);
        }

        [TestMethod()]
        public void CalculateTaxNotImportTest()
        {

            Product product = new Products.Product(1, "TestProduct", 10, Taxes.VATType.Basic, false);
            
            
            
            Assert.IsTrue(Taxes.TaxCalculator.CalculateItemImportTax(product)== 0);
            
        }

       

        [TestMethod()]
        public void CalculateTaxVatExempt()
        {

            Product product = new Products.Product(1, "TestProduct", 10, Taxes.VATType.Exempt, true);
           
            
            Assert.IsTrue(Taxes.TaxCalculator.CalculateItemVAT(product) == 0);
        }

       

    }
}