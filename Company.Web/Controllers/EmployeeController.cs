using Company.Data.Entites;
using Company.Service.Interfaces;
using Company.Service.Interfaces.Employee.Dto;
using Company.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace Company.Web.Controllers
{
	public class EmployeeController : Controller
	{
		private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;

        public EmployeeController(IEmployeeService employeeService, IDepartmentService departmentService)
		{
			_employeeService = employeeService;
            _departmentService = departmentService;
        }

		[HttpGet]
		public IActionResult Index(string searchInp)
		{
			IEnumerable<EmployeeDto> employees = new List<EmployeeDto>();

			if(string.IsNullOrEmpty(searchInp))
				employees = _employeeService.GetAll();
			else
				employees = _employeeService.GetEmployeeByName(searchInp);

			return View(employees);

		}

		[HttpGet]
		public IActionResult Create()
		{
			ViewBag.Departments = _departmentService.GetAll();
			return View();
		}


        public IActionResult Create(EmployeeDto employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _employeeService.Add(employee);

                    return RedirectToAction("Index");

                }


                return View(employee);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("EmployeeError", ex.Message);

                return View(employee);
            }
        }

    }
}
