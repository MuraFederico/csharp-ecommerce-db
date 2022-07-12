// See https://aka.ms/new-console-template for more information

/*Product.Create("laptop", 2000, "descrizione laptop");
Product.Create("Lampada", 20, "descrizione lampada");
Product.Create("Divano", 500, "descrizione divano");*/


//Customer.Create("Federico", "Mura", "federico@mura.com");
//Customer.Create("Marco", "Rossi", "marco@rossi.com");



  ////////////////
 ////ADD ORDER //
////////////////

/*using (EcommerceContext db = new EcommerceContext())
{
    Customer customer = db.Customers.Where(customer => customer.Id == 2).First();
    List<Product> products = db.Products.ToList();
    Order order = new Order { CustomerId = customer.Id, Date = DateTime.Now, Status = "in corso", Products = products };
    db.Add(order);
    db.SaveChanges();

    foreach (Product product in order.Products)
    {
        OrderProduct pivot = product.OrderProducts.Where(op => op.ProductId == product.Id).First();
        pivot.Quantity = new Random().Next(1, 6);
        order.Amount += product.Price * pivot.Quantity;
    }

    db.SaveChanges();
}*/



  //////////////////////////
 /// RETRIVE ORDER LIST ///
//////////////////////////

using(EcommerceContext db = new EcommerceContext())
{
    List<Order> orders = db.Orders.Where(order => order.CustomerId == 2).ToList();
    Console.WriteLine("date \t\t\tamount");
    foreach (Order order in orders)
    {
        Console.WriteLine(order.Date + "\t" + order.Amount);
    }
}




  ////////////////////////
 ///DELETE ALL ORDERS ///
////////////////////////

//using (EcommerceContext db = new EcommerceContext())
//{
//    foreach (Order order in db.Orders)
//    {
//        db.Remove(order);
//    }
//    db.SaveChanges();
//}