namespace Turbokart.Domain.Entities
{
    /// <summary>
    /// bla bla
    /// </summary>
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime Start { get; set; }
        public Customer? Customer { get; set; }
        public int CustomerId { get; set; }
    }
}