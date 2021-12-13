using System.Collections.Generic;

public class InsertOrderRequest
{
    public int Id { get; set; }
    public string Status { get; set; }
    public int UserId { get; set; }
    public List<int> ProductsId { get; set; }
    public string ShippingAddress { get; set; }
    public string BillingAddress { get; set; }
}

