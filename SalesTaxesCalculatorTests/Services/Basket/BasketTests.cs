using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesTaxesCalculator.Services.Basket;
using SalesTaxesCalculator.Services.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesCalculator.Services.Basket.Tests
{
    [TestClass()]
    public class BasketTests
    {
        
        [TestMethod()]
        public void AddItem1Test()
        {

            Basket basket = new Basket();
            basket.AddItem(new Products.Product(1, "book", 12.49, Taxes.VATType.Exempt, false));
            basket.AddItem(new Products.Product(2, "music CD", 14.99, Taxes.VATType.Basic, false));
            basket.AddItem(new Products.Product(3, "chocolate bar", 0.85, Taxes.VATType.Exempt, false));
            Assert.IsTrue(basket.Items.Count == 3);
            Assert.IsTrue(basket.Subtotal == 28.33);
            Assert.IsTrue(basket.Total == 29.83);
            Assert.IsTrue(basket.Taxes == 1.5);
        }

    }
}