namespace SpikeDashboard.Models
{
    public class DashboardCardModel
    {
        public string title { get; set; }
        public double value { get; set; }
        public string valueType { get; set; } = "number";
        public double change { get; set; }

        public int lastWeekChange { get; set; }

    }
}