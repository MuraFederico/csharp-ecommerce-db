// See https://aka.ms/new-console-template for more information

/*Product.Create("laptop", 2000, "descrizione laptop");
Product.Create("Lampada", 20, "descrizione lampada");
Product.Create("Divano", 500, "descrizione divano");*/


//Customer.Create("Federico", "Mura", "federico@mura.com");
//Customer.Create("Marco", "Rossi", "marco@rossi.com");


using (EcommerceContext db = new EcommerceContext())
{
    Customer customer = db.Customers.Where(customer => customer.Id == 1).First();
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
}

//using (EcommerceContext db = new EcommerceContext())
//{
//    foreach (Order order in db.Orders)
//    {
//        db.Remove(order);
//    }
//    db.SaveChanges();
//}