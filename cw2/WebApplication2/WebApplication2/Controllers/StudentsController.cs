using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public string GetStudents([FromQuery] string orderBy)
        {
            return $"Anna, Marcin, Zenon {orderBy}";
        }

        [HttpGet("{id}")]
        public string GetStudents()
        {
            if (id == 1)
        {
                return "Jan Pietrzak";
            }
            return "Nie znaleziono";
        }

        [HttpPost]
        public IActionResult createStudent(Student student)
        {
        student.IndexNumber=$"s{ new Random().Next(1, 10000)}";
        return OK(student);
        }

    }
}