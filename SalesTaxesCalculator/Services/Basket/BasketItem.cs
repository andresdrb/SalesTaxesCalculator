using SalesTaxesCalculator.Services;
using SalesTaxesCalculator.Services.Products;

namespace SalesTaxesCalculator.Services.Basket
{
    public class BasketItem
    {
        public BasketItem(Product product, int count)
        {
            this.Item = product;
            this.Count = count;
        }

        private Product item;
        public Product Item
        {
            get { return item; }
            set { item = value; }
        }

        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

       


    }
}