using SalesTaxesCalculator.Services.Products;
using SalesTaxesCalculator.Services.Taxes;
using System;
using System.Collections;
using System.Collections.Generic;


namespace SalesTaxesCalculator.Services.Basket
{
    /// <summary>
    /// Class meant to hold the products on the shopping backet
    /// </summary>
    public class Basket
    {

        public Basket()
        {
            Items = new Dictionary<int, BasketItem>();
        }

        private Dictionary<int,BasketItem> items;
        public Dictionary<int, BasketItem> Items
        {
            get { return items; }
            set { items = value; }
        }

        private double subtotal;
        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        public double Total
        {
            get { return subtotal+ Taxes; }

        }


        private double taxes;
        public double Taxes
        {
            get { return taxes; }
            set { taxes = value; }
        }

        /// <summary>
        /// Add an item into the basket and recalculate the basket total and taxes accordingly
        /// </summary>
        /// <param name="product">The product to be added to the basket</param>
        /// <returns>True if successfull, false if failed</returns>
        public void AddItem(Product product)
        {

            try
            {
                if (items.ContainsKey(product.ProductId))
                {
                    items[product.ProductId].Count++;

                }
                else
                {
                    BasketItem item = new BasketItem(product, 1);
                    items.Add(product.ProductId, item);
                }



                this.Subtotal += product.PriceSalesExclusive;
                this.Subtotal = Math.Round(this.Subtotal, 2);
                this.Taxes += product.ImportTaxes + product.VatTaxes;
                this.Taxes = Math.Round(this.Taxes, 2);
            }
            catch (Exception ex)
            {
                //TODO: Implement logging
                throw;
            }

           
        }


    }
}