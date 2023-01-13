namespace App.Models
{
    internal class Event
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime RealizationDate { get; set; }
        public int SupervisorId { get; set; }

    }
}
