using System.Collections.Generic;

public class InsertOrderResponse
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }
    }

