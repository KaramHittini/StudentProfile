using Microsoft.AspNetCore.Mvc;
using StudentProfile.Models;

namespace StudentProfile.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            var profile = new StudentProfileModel
            {
                FullName = "Karam Hisham Hittini",
                Major = "Software Engineering",
                GPA = 3.25,
                DateOfBirth = "31 / 08 / 2006",
                CompletedHours = 95,
                UniversityId = "202302569",
                Degree = "Bachalorious",
                College = "Information Technology",
                StudentStatus = "Regular",
                StudyType = "Male",
                PlanNumber = "11",
                AdmissionYearSemester = "1/2023",
                AcademicAdvisor = "Dr.who",
                ExpectedGraduation = "No",
                VolunteerHours = 37
            };

            return View(profile);
        }
    }
}
