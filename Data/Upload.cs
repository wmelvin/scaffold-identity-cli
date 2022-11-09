namespace demo_webapp.Data
{
    public class Upload
    {
        public int Id { get; set; }

        public string FileName { get; set; }

        public string? ContentType { get; set; }
 
        public DateTime WhenUploaded { get; set; }

        public int User_Id { get; set; }
    }
}
