namespace WMK_Web.Models
{
    public class Session
    {
        public int Id { get; set; }
        public enum Comments { Rozmowy, Rozprawy, Korespondencja, Pisma, Analiza, Rekomendacje, Inne }
        public DateTime StartTime { get; set; }
        public TimeSpan Time { get; set; }
        public Comments Comment { get; set; }
        public string? CustomComment { get; set; }
        public bool UserEdited { get; set; } = false;
        public bool Archived { get; set; } = false;
        private DateTime _EndTime
        {
            get { return StartTime + Time; }

            set { _EndTime = value; }
        }
    }
}
