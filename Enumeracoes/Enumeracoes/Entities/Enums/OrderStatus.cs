using System;

namespace Course.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2, 
        Shipping = 3,
        Delivered = 4
    }
}
