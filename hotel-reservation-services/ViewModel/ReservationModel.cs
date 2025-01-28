namespace hotel_reservation_services.ViewModel
{
    public class ReservationModel
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int ClientId { get; set; }
        public int RoomId { get; set; }
        public double Price { get; set; }
        public int? PaymentId { get; set; }
        public string Status => PaymentId != null ? "Paid" : "Not Paid";
    }
}