using SecondMVCApp.Models;
using System.Web.Mvc;
using Week4.Shared.Enums;

namespace SecondMVCApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {

            var studentModel = new StudentModel
            {
                FirstName = "Michelle",
                LastName = "Taylor",
                Gender = GenderEnum.Female,
                Age = 24,
                Major = "Business Information Systems"
            };

            return View(studentModel);
        }
    }
}