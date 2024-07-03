using Microsoft.AspNetCore.Mvc;
using StudentRegistration.Web.Data;
using StudentRegistration.Web.Models;

namespace StudentRegistration.Web.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _dbcontext;

        public StudentsController(ApplicationDbContext dbContext)
        {
            _dbcontext = dbContext;

        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Students> students1 = _dbcontext.Students.ToList();


            return View(students1);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Students students)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.Students.Add(students);
                _dbcontext.SaveChanges();

                TempData["success"] = "Student Registered Successfully";

                return RedirectToAction(nameof(Index));
            }

            return View();

        }


        [HttpGet]

        public IActionResult Details(Guid id)
        {
            Students students = _dbcontext.Students.FirstOrDefault(x => x.Id == id);

            return View(students);
        }

        [HttpGet]

        public IActionResult Edit(Guid id)
        {
            Students students = _dbcontext.Students.FirstOrDefault(x => x.Id == id);

            return View(students);
        }

        [HttpPost]

        public IActionResult Edit(Students students)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.Students.Update(students);
                _dbcontext.SaveChanges();

				TempData["warning"] = "Student Record updated Sucessfully";

				return RedirectToAction(nameof(Index));

            }
            
                return View();
        }

		[HttpGet]
		public IActionResult Delete(Guid id)
		{
			Students students = _dbcontext.Students.FirstOrDefault(x => x.Id == id);

			return View(students);
		}

        [HttpPost]

        public IActionResult Delete(Students students)
        {
			if (ModelState.IsValid)
			{
				_dbcontext.Students.Remove(students);
				_dbcontext.SaveChanges();

				TempData["error"] = "Student Record Deleted Sucessfully";

				return RedirectToAction(nameof(Index));

			}
            return View();

		}

	}
}
