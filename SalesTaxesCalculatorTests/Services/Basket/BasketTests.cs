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

        [TestMethod()]
        public void AddItem2Test()
        {

            Basket basket = new Basket();
            basket.AddItem(new Products.Product(1, "imported box of chocolates", 10, Taxes.VATType.Exempt, true));
            basket.AddItem(new Products.Product(2, "imported bottle of perfume", 47.5, Taxes.VATType.Basic, true));
            Assert.IsTrue(basket.Items.Count == 2);
            Assert.IsTrue(basket.Subtotal == 57.5);
            Assert.IsTrue(basket.Total == 65.15);
            Assert.IsTrue(basket.Taxes == 7.65);
        }

        [TestMethod()]
        public void AddItem3Test()
        {

            Basket basket = new Basket();
            basket.AddItem(new Products.Product(1, "imported bottle of perfume", 27.99, Taxes.VATType.Basic, true));
            basket.AddItem(new Products.Product(2, "bottle of perfume", 18.99, Taxes.VATType.Basic, false));
            basket.AddItem(new Products.Product(3, "packet of headache pills", 9.75, Taxes.VATType.Exempt, false));
            basket.AddItem(new Products.Product(4, "box of imported chocolates", 11.25, Taxes.VATType.Exempt, true));
            Assert.IsTrue(basket.Items.Count == 4);
            Assert.IsTrue(basket.Subtotal == 67.98);
            Assert.IsTrue(basket.Total == 74.68);
            Assert.IsTrue(basket.Taxes == 6.7);

        }

    }
}