namespace Course.Entities.Enums{
    internal enum OrderStatus : int //Definindo o tipo do ENUM
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3,
    }

}