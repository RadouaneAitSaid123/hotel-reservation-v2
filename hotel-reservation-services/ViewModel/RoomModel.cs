namespace hotel_reservation_services.ViewModel
{
    public class RoomModel
    {
        public int ID { get; set; }
        public required string Number { get; set; }
        public bool IsAvailable { get; set; }
        public int RoomTypeId { get; set; }
    }
}