using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace MainProject.Models
{
    public class FullData
    {
        //1 Card 0 No Card
        public bool MethodOfpayment { get; set; }
        public double DepositedSum { get; set; }
        public string? TimeOfPurchase { get; set; }

        public List<ListOfProducts>? ListOfProducts { get; set; }

        public FullData() { }

    }

    public class ListOfProducts
    {
        public string? NameProduct { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public ListOfProducts() { }
        public ListOfProducts(string NameProduct,double Price, int Quantity) 
        {
            this.NameProduct = NameProduct;
            this.Price = Price;
            this.Quantity = Quantity;
        }
    }

}
