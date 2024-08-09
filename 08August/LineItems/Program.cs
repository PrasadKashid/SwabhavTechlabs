using ProductDiscountApp.Model;

class Program
{
    public static void Main(string[] args)
    {
        Product product1 = new Product(1, "iPhone 15", 70000, 5);
        Product product2 = new Product(2, "Lenovo ThinPad", 35000, 5);
        Product product3 = new Product(3, "Amazon Alexa", 7000, 0);
        Product product4 = new Product(4, "Ipad Pro", 90000, 10);

        LineItem lineItem1 = new LineItem(1, 5, product1);
        LineItem lineItem2 = new LineItem(2, 2, product2);
        LineItem lineItem3 = new LineItem(3, 1, product3);
        LineItem lineItem4 = new LineItem(4, 2, product4); 

        List<LineItem> list1 = new List<LineItem>();

        list1.Add(lineItem1);
        list1.Add(lineItem2);
        list1.Add(lineItem3);
        list1.Add(lineItem4);

        Order order1 = new Order(1, DateTime.Now, list1);

        List<Order> orders = new List<Order>();
        orders.Add(order1);

        Product product5 = new Product(1, "Samsung Fold", 150000, 5);
        Product product6 = new Product(2, "Washing Machine", 25000, 5);
        Product product7 = new Product(3, "Bluedart AC", 45000, 5);
        Product product8 = new Product(4, "Refridgerator ", 17000, 3);

        LineItem lineItem5 = new LineItem(1, 2, product5);
        LineItem lineItem6 = new LineItem(2, 1, product6);
        LineItem lineItem7 = new LineItem(3, 3, product7);
        LineItem lineItem8 = new LineItem(4, 1, product8);

        List<LineItem> list2 = new List<LineItem>();
        list2.Add(lineItem5);
        list2.Add(lineItem6);
        list2.Add(lineItem7);
        list2.Add(lineItem8);

        Order order2 = new Order(2, DateTime.Now, list2);


        orders.Add(order2);

        Customer customer = new Customer(1, "Prasad", orders);

        Console.WriteLine("Customer Id : " + customer.CustomerId);
        Console.WriteLine("Customer Name : " + customer.CustomerName);
        Console.WriteLine();
        Console.WriteLine("Order Details : ");
        Console.WriteLine();

        foreach (Order order in orders)
        {
            Console.WriteLine("Order id is " + order.OrderId);
            Console.WriteLine("Order Date is " + order.Date);
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"{"Line Item",-10}  |  {"Product Item",-10}  |  {"Product Name",-16} |  {"Quantity",-11} |  {"Unit Price",-10}  |  {"Discount",-11}  |  {"Cost after Discount",-20}  |  {"Total Line Item Cost",-20} |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
            foreach (LineItem lineItem in order.lineItems)
            {
                Console.WriteLine($"{lineItem.ItemId,-10}  |  {lineItem.product.ProductId,-12}  |  {lineItem.product.ProductName,-15}  |  {lineItem.ItemQuantity,-10}  |  {lineItem.product.ProductPrice,-10}  |  {lineItem.product.ProductDiscountPercent+" % ",-11}  |  {lineItem.product.CalculateDiscountPrice(),-20}  |  {lineItem.CalculateLineItemCost(),-20} |");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
            }
            Console.WriteLine($"{"Sub Total",-10}  |  {"",-12}  |  {"",-16} |  {"",-11} |  {"",-10}  |  {"",-11}  |  {"",-20}  |  {order.CalculateOrderPrice(),-20} |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public static void PrintBill(Customer customer)
    {

    }

}