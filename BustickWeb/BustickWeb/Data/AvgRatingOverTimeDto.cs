namespace BustickWeb.Data
{
    public class AvgRatingOverTimeDto
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public double AverageRating { get; set; }

        public string Label { get; set; } = "";
    }
}
