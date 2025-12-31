using Microsoft.AspNetCore.Mvc;
using StudentProfile.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentProfile.Controllers
{
    public class CourseRegistrationController : Controller
    {
        private static List<CourseModel> AllCourses = new()
        {
            new CourseModel { Id = Guid.NewGuid(), Code = "CS101", Name = "Intro to CS", Credits = 3, CapacityStatus = "Available" },
            new CourseModel { Id = Guid.NewGuid(), Code = "CS102", Name = "Data Structures", Credits = 4, CapacityStatus = "Available" },
            new CourseModel { Id = Guid.NewGuid(), Code = "CS103", Name = "Databases", Credits = 3, CapacityStatus = "Full" }
        };

        private static List<Guid> RegisteredCourseIds = new();

        public IActionResult Index()
        {
            var model = new CourseRegistrationModel
            {
                AvailableCourses = AllCourses.Select(c => new CourseModel
                {
                    Id = c.Id,
                    Code = c.Code,
                    Name = c.Name,
                    Credits = c.Credits,
                    CapacityStatus = c.CapacityStatus,
                    IsRegistered = RegisteredCourseIds.Contains(c.Id),
                    CanRegister = !RegisteredCourseIds.Contains(c.Id) && c.CapacityStatus != "Full"
                }).ToList(),

                RegisteredCourses = AllCourses.Where(c => RegisteredCourseIds.Contains(c.Id)).ToList()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult RegisterCourse(Guid courseId)
        {
            var course = AllCourses.FirstOrDefault(c => c.Id == courseId);
            if (course != null && !RegisteredCourseIds.Contains(courseId) && course.CapacityStatus != "Full")
            {
                RegisteredCourseIds.Add(courseId);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DropCourse(Guid courseId)
        {
            if (RegisteredCourseIds.Contains(courseId))
            {
                RegisteredCourseIds.Remove(courseId);
            }
            return RedirectToAction("Index");
        }
    }
}
