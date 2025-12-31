using Microsoft.AspNetCore.Mvc;
using StudentProfile.Models;
using System;
using System.Collections.Generic;

namespace StudentProfile.Controllers
{
    public class ProfileController : Controller
    {
        // Mock student database
        private static readonly Dictionary<string, StudentProfileModel> Students = new()
        {
            {
                "Karam Hittini",
                new StudentProfileModel
                {
                    FullName = "Karam Hisham",
                    Major = "Software Engineering",
                    GPA = 3.75,
                    DateOfBirth = "15 / 05 / 2006",
                    CompletedHours = 80,
                    UniversityId = "202302569",
                    Degree = "Bachelors",
                    College = "Information Technology",
                    StudentStatus = "Regular",
                    StudyType = "Day",
                    PlanNumber = "11",
                    AdmissionYearSemester = "2023 / 1",
                    AcademicAdvisor = "Hamed Jassim Al-Fawaareh",
                    ExpectedGraduation = "No",
                    VolunteerHours = 37
                }
            },
            {
                "Obida Amer",
                new StudentProfileModel
                {
                    FullName = "Obida Amer Arkawi",
                    Major = "Computer Science",
                    GPA = 3.35,
                    DateOfBirth = "21 / 10 / 2005",
                    CompletedHours = 92,
                    UniversityId = "202302566",
                    Degree = "Bachalorious",
                    College = "Information Technology",
                    StudentStatus = "Regular",
                    StudyType = "Male",
                    PlanNumber = "11",
                    AdmissionYearSemester = "1 / 2023",
                    AcademicAdvisor = "Dr.who",
                    ExpectedGraduation = "No",
                    VolunteerHours = 30
                }
            },
            {
                "Mustafa Omar",
                new StudentProfileModel
                {
                    FullName = "Mustafa Omar Al Hamad",
                    Major = "Cyber Security",
                    GPA = 3.00,
                    DateOfBirth = "1 / 5 / 2005",
                    CompletedHours = 85,
                    UniversityId = "202301969",
                    Degree = "Bachalorious",
                    College = "Information Technology",
                    StudentStatus = "Regular",
                    StudyType = "Male",
                    PlanNumber = "11",
                    AdmissionYearSemester = "1 / 2023",
                    AcademicAdvisor = "Dr.who",
                    ExpectedGraduation = "No",
                    VolunteerHours = 19
                }
            }
        };

        // Simulated login
        public IActionResult Index(string email = "202302569@zu.edu.jo")
        {
            if (!Students.ContainsKey(email))
            {
                return NotFound("Student not found.");
            }

            var model = Students[email];
            return View(model);
        }
    }
}
