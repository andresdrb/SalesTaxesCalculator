using SalesTaxesCalculator.Services.Basket;
using SalesTaxesCalculator.Services.Products;
using System;
using SalesTaxesCalculator.Services.Taxes;
using SalesTaxesCalculator.Services.Printer;

namespace SalesTaxesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Basket basket = new Basket();
            basket.AddItem(new Product(1, "book", 12.49, VATType.Exempt, false));
            basket.AddItem(new Product(2, "music CD", 14.99, VATType.Basic, false));
            basket.AddItem(new Product(3, "chocolate bar", 0.85, VATType.Exempt, false));

            Printer.PrintBasket(basket);


             basket = new Basket();
            basket.AddItem(new Product(1, "imported box of chocolates", 10, VATType.Exempt, true));
            basket.AddItem(new Product(2, "imported bottle of perfume", 47.5, VATType.Basic, true));

            Printer.PrintBasket(basket);

            basket = new Basket();
            basket.AddItem(new Product(1, "imported bottle of perfume", 27.99, VATType.Basic, true));
            basket.AddItem(new Product(2, "bottle of perfume", 18.99, VATType.Basic, false));
            basket.AddItem(new Product(3, "packet of headache pills", 9.75, VATType.Exempt, false));
            basket.AddItem(new Product(4, "box of imported chocolates", 11.25, VATType.Exempt, true));

            Printer.PrintBasket(basket);

            Console.WriteLine("Press Enter to finish");
            Console.ReadLine();

        }
    }
}
