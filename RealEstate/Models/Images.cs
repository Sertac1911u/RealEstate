namespace RealEstate.Models
{
    public class Images
    {
        public Guid guid { get; set; }
        public Guid estate_id { get; set; }
        public string image_url { get; set; }
        public string image_path { get; set; }
        public bool is_primary { get; set; }
        public int image_order { get; set; }
        public DateTime created_at { get; set; }
    }
}
