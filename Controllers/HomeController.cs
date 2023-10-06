using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "silly horse", StudentId = "S001", StudentAge = "20" },
            new StudentInfoModel { Name = "Michelle Tabaloc", StudentId = "S002", StudentAge = "22" },
            new StudentInfoModel { Name = "Raiden Tabaloc", StudentId = "S003", StudentAge = "31" }
        };

        return View(studentInfoArray);
    }
}
