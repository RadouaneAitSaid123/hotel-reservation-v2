namespace hotel_reservation_services.ViewModel
{
    public class PaymentModel
    {
        public int ID { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string PaymentMethod { get; set; }
    }
}