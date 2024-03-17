using WebApplication1.Enums;

namespace WebApplication1.Models.Create
{
    public class CreateUserTask_00013540
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTimeOffset DueDate { get; set; }

        public int? Status { get; set; }

        public PrioritiesEnum_00013540 Priority { get; set; }
    }
}