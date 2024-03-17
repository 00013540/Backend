using WebApplication1.Enums;

namespace WebApplication1.Models
{
    public class UserTask_00013540
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTimeOffset DueDate { get; set; }

        public int? Status { get; set; }

        public PrioritiesEnum_00013540 Priority { get; set; } 
    }
}