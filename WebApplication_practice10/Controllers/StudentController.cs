using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication_practice10.Models;
namespace WebApplication_practice10.Controllers

{
    //[Route("[controller]/[action]")]
    public class StudentController : Controller
    {
        List<Student> studentList;
        public StudentController()
        {
            studentList = new List<Student>
            {
                            new Student() {LastName = "Karimbayev",FirstName = "Dinmukhammed", Group = "SWD-1704",Birth = new DateTime(1998,07,06) },
                            new Student() {LastName = "Bershimbekov",FirstName = "Bekzhan", Group = "IS-1709",Birth = new DateTime(1999,12,14) },
                            new Student() {LastName = "Kenzhebayev",FirstName = "Azamat", Group = "RET-1711",Birth = new DateTime(1999,08,18) },
                            new Student() {LastName = "Muslimova",FirstName = "Karina", Group = "JUR-1701",Birth = new DateTime(1998,03,01) },
                            new Student() {LastName = "Momishuly",FirstName = "Nursultan", Group = "FIS-1711",Birth = new DateTime(1998,12,31) },
                            new Student() {LastName = "Taubaldiyeva",FirstName = "Aruzhan", Group = "SWD-1706",Birth = new DateTime(2000,10,22) },
                            new Student() {LastName = "Iliyas",FirstName = "Yeleubay", Group = "SWD-1704",Birth = new DateTime(2001,04,17) }
            };

            foreach (Student s in studentList)
            {
                string code = s.Group.Substring(s.Group.Length - 4);
                code += s.FirstName[0];
                code += s.LastName[0];
                code += s.Birth.Year.ToString().Substring(s.Birth.Year.ToString().Length - 2);
                s.Zipcode = code;
            }
        }
        //[Route("/")]
        public IActionResult Index()
        {
            return View(studentList);
        }
        [HttpPost]
        //[Route("/search")]
        public IActionResult Index(string search)
        {
            Student m1 = studentList.Find(x => x.Zipcode.Equals(search));
            return Content(m1.FirstName+' '+m1.LastName);
        }
    }
}