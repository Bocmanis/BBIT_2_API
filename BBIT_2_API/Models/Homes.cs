﻿namespace BBIT_2_API
{
    public class Homes
    {
        public int Id { get; set; }
        public string HouseNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public List<Apartments> Apartments { get; set; }

    }
}
