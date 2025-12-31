namespace StudentProfile.Models
{
    public class CourseRegistrationModel
    {
        public List<CourseModel> AvailableCourses { get; set; } = new();
        public List<CourseModel> RegisteredCourses { get; set; } = new();
    }

    public class CourseModel
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public string CapacityStatus { get; set; } // e.g., "Full", "Available"
        public bool IsRegistered { get; set; }
        public bool CanRegister { get; set; } // false if conflicts or prereqs not met
    }
}
