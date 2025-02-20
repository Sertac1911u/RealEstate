namespace RealEstate.Models
{
    public class Estates
    {
        public Guid guid { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Guid category_guid { get; set; }
        public float price { get; set; }
        public int square_meter { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string neighborhood { get; set; }
        public string street { get; set; }
        public string building_name { get; set; }
        public int floor_number { get; set; }
        public int apartment_number { get; set; }
        public int latitude { get; set; }
        public int longitude { get; set; }
        public int building_age { get; set; }
        public int room_count { get; set; }
        public int bathroom_count { get; set; }
        public int balcony_count { get; set; }
        public string heating_type { get; set; }
        public int has_elevator { get; set; }
        public int has_parking { get; set; }
        public int is_active { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
