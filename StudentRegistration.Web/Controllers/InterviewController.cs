using Microsoft.AspNetCore.Mvc;
using StudentRegistration.Web.Data;
using StudentRegistration.Web.Models;

namespace StudentRegistration.Web.Controllers
{
    public class InterviewController : Controller
    {
        private readonly ApplicationDbContext _dbcontext;

        public InterviewController(ApplicationDbContext dbContext)
        {
            _dbcontext=dbContext;
        }




        [HttpGet]

        public IActionResult Index1()
        {
            List<Interview> interview1 = _dbcontext.Interviews.ToList();

            return View(interview1);
        }

		[HttpGet]

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Interview interview)
		{
			if (ModelState.IsValid)
			{
				_dbcontext.Interviews.Add(interview);
				_dbcontext.SaveChanges();

				return RedirectToAction(nameof(Index1));
			}

			return View();

		}

		[HttpGet]

		public IActionResult Details(int Sno)
		{
			Interview interview= _dbcontext.Interviews.FirstOrDefault(x => x.Sno == Sno);

			return View(interview);
		}



		[HttpGet]

		public IActionResult Edit(int Sno)
		{
			Interview interview = _dbcontext.Interviews.FirstOrDefault(x => x.Sno == Sno);

			return View(interview);
		}


		[HttpPost]

		public IActionResult Edit(Interview interview)
		{
			if (ModelState.IsValid)
			{
				_dbcontext.Interviews.Update(interview);
				_dbcontext.SaveChanges();

				return RedirectToAction(nameof(Index1));

			}

			return View();
		}


		[HttpGet]
		public IActionResult Delete(int Sno)
		{
			Interview interview = _dbcontext.Interviews.FirstOrDefault(x => x.Sno == Sno);

			return View(interview);
		}

		[HttpPost]
		public IActionResult Delete(Interview interview)
		{
			if (ModelState.IsValid)
			{
				_dbcontext.Interviews.Remove(interview);
				_dbcontext.SaveChanges();

				return RedirectToAction(nameof(Index1));

			}
			return View();

		}


	}
}
