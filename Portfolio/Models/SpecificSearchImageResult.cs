namespace Portfolio.Models
{
    public class SpecificSearchImageResult
    {
        public string full { get; set; }
        public string download { get; set; }

        public SpecificSearchImageResult(string _full, string _download)
        {
            full = _full;
            download = _download;    
        }
    }
}
