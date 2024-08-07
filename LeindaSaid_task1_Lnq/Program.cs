using System.Collections.Generic;
using System.ComponentModel;
using static LeindaSaid_task1_Lnq.ListGenerator;
namespace LeindaSaid_task1_Lnq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ques1
            // - Write a LINQ query to find all products in ProductList that belong to the category "Condiments".

            //var productInProductList = ProductList.Where (p => p.Category == "Condiment");

            //foreach (var product in productInProductList )
            //    {
            //        Console.WriteLine( product);
            //    }

            #endregion

            #region ques2
            // -Write a LINQ query to select only the ProductName and UnitPrice of products from ProductList.
            //var ProductUnitPrice = ProductList.Select (p => new { p.ProductName, p.UnitPrice });

            //foreach (var product in ProductUnitPrice)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region ques3
            //- Write a LINQ query to order the products in ProductList by UnitPrice in descending order.
            //var ProductUnitPrice = ProductList.OrderByDescending(p => p.UnitPrice);

            //foreach (var product in ProductUnitPrice)
            //{
            //    Console.WriteLine(product);
            //}


            #endregion

            #region ques4
            //- Write a LINQ query to group products from ProductList by Category and count the number of products in each category.
            //var products = ProductList.GroupBy(product => product.Category).Select(ProductCount => new { Category = ProductCount.Key, Count = ProductCount.Count() });

            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #region ques5
            //- Write a LINQ query to find all products in ProductList that have more than 10 units in stock.
            //var products = ProductList.Where(product => product.UnitsInStock > 10);
            #endregion

            #region ques6
            //- Write a LINQ query to find all customers from CustomerList who are from the country "Germany".
            //var customers = CustomerList.Where(customer => customer.Country == "Germany");
            #endregion

            #region ques7
            //- Write a LINQ query to select the CustomerName and City of all customers from CustomerList.
            //var customers = CustomerList.Select (C => new{ C.CustomerName, C.City });
            #endregion

            #region ques8
            //var customerAlist = CustomerList.OrderBy (C => C.City );

            #endregion

            #region ques9
            // - Write a LINQ query to find all customers from CustomerList who have at least one order in their Orders array.
            //var customers = CustomerList.Where(C => C.Orders.Any());

            //    foreach (var CustomerList in customers)
            //    {
            //        Console.WriteLine( CustomerList );
            //    }

            #endregion

            #region ques10
            // - Write a LINQ query to count the number of orders for each customer and return the CustomerName along with the order count.
            //var customer = CustomerList.Select(customer => new { customer.CustomerName, Count = customer.Orders.Count() });

            //foreach (var customers in customer)
            //    {
            //        Console.WriteLine(customer);
            //    }
            #endregion

            #region ques11
            // - Write a LINQ query to find all orders in the Orders array where the Total is greater than $500.
            //var Orders = CustomerList.SelectMany(customer => customer.Orders).Where (order => order.Total > 500);

            //foreach (var Order in Orders)
            //{
            //    Console.WriteLine(Order);
            //}
            #endregion

            #region ques12
            // -Write a LINQ query to find the most expensive product in ProductList.
            var MostExpensiveProductList = ProductList.Max(p => p.UnitPrice);
             Console.WriteLine(MostExpensiveProductList);
            #endregion

            #region ques13
             
            //-Write a LINQ query to find all customers who have at least one order with a Total amount greater than $300.
            var customers = CustomerList.Where( customer => customer.Orders.Any( Order => Order.Total > 300));

            foreach (var customerOfTotalAmount in customers)
                {
                    Console.WriteLine( customerOfTotalAmount );
                }
            #endregion

            #region ques14
            // - Write a LINQ query to find all products in ProductList that have 5 or fewer units in stock.
             var products = ProductList.Where( P => P.UnitsInStock <= 5);
            #endregion


        }
    }
}
