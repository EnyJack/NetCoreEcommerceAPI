namespace NetCoreAPI.Entities
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImageUrl { get; set; }
        public string ImageName { get; set; }
        public string Decription { get; set; }
        public Product Product { get; set; }
    }
}