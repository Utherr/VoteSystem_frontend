using Microsoft.AspNetCore.Mvc;
using StudentManagement21A6.Data;
using StudentManagement21A6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement21A6.Controllers
{
    public class StudentViewsController : Controller
    {
        private readonly StudentContext _context;



        public StudentViewsController(StudentContext context)
        {
            _context = context;
        }



        public IActionResult Index()
        {
            //HasNoKey();



            var alist = from s in _context.Student
                        join sa in _context.Specialization on s.Spec equals sa.Id
                        //where s.G_ID == 1
                        select new StudentView
                        {
                            studentsVm = s,
                            specializationVm = sa,



                        };



            return View(alist.ToList());
        }



        // GET: Students/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }



            var alist = from s in _context.Student
                        join sa in _context.Specialization on s.Spec equals sa.Id
                        where s.Id == id
                        select new StudentView
                        {
                            studentsVm = s,
                            specializationVm = sa,



                        };




            return View(alist.FirstOrDefault());
        }



    }


}
