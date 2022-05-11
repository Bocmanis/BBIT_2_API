namespace BBIT_2_API
{
    public class Apartments
    {
        public int Id { get; set; }
        public int ApartmentNumber { get; set; }
        public int Floor { get; set; }
        public int NumberOfRooms { get; set; }
        public int NumberOfResidents { get; set; }
        public int Area { get; set; }       //dzivojama kvadratura
        public int LivingSpace { get; set; }    //kopeja kvadratura
        public int HomeId { get; set; }
        public Homes Home { get; set; }
        public List<Residents> Residents { get; set; }
    }
}
