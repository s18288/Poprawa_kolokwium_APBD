namespace poprawa_kolokwium_S18288.Entities
{
    public class File
    {
        public int FileId { get; set; }
        public Team Team { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public int FileSize { get; set; }
    }
}
