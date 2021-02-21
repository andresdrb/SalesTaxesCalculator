using SalesTaxesCalculator.Services.Taxes;

namespace SalesTaxesCalculator.Services.Products
{
    public class Product
    {

        public Product(int productId, string productName, double priceSalesExclusive, VATType taxVATTypeId, bool imported)
        {
            ProductId = productId;
            ProductName = productName;
            PriceSalesExclusive = priceSalesExclusive;
            TaxVATTypeId = taxVATTypeId;
            Imported = imported;
        }

        private int productId;
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private string productName;
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private double priceSalesExclusive;
        public double PriceSalesExclusive
        {
            get { return priceSalesExclusive; }
            set { priceSalesExclusive = value; }
        }

        private VATType taxVATTypeId;
        public VATType TaxVATTypeId
        {
            get { return taxVATTypeId; }
            set { taxVATTypeId = value; }
        }

        private double vatTaxes;
        public double VatTaxes
        {
            get { return Taxes.TaxCalculator.CalculateItemVAT(this); }
    
        }

        private double importTaxes;
        public double ImportTaxes
        {
            get { return Taxes.TaxCalculator.CalculateItemImportTax(this); }

        }


        private bool imported;
        public bool Imported
        {
            get { return imported; }
            set { imported = value; }
        }





    }
}