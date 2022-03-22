using Microsoft.AspNetCore.Mvc;
using MyMicroservice.Models;

namespace MyMicroservice.Controllers;

[ApiController]
[Route("[controller]")]
public class CourseController : ControllerBase
{
    private static readonly string[] SampleCourseNames = new[]
    {
        "Introduction to Microservices", 
        "Introduction to Docker", 
        "Microservices Patterns", 
        "Building Microservices", 
        "Building Microservices: Designing Fine-Grained Systems", 
        "Microservices for the Enterprise: Designing, Developing, and Deploying", 
        "Building Event-Driven Microservices", 
        "Building Server-side and Microservices with Go", 
        "Microservices in Action", 
        "Spring Microservices in Action"
    };

    private readonly ILogger<CourseController> _logger;

    public CourseController(ILogger<CourseController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCourse")]
    public IEnumerable<Course> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Course
        {
            DateCreated = DateTime.Now.AddDays(index*-1),
            Price = Random.Shared.Next(50, 500),
            Title = SampleCourseNames[Random.Shared.Next(SampleCourseNames.Length)]
        })
        .ToArray();
    }
}
