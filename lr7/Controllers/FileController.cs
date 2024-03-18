using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Threading.Tasks;

namespace lr7.Controllers
{
    public class FileController : Controller
    {
        public IActionResult DownloadFile()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DownloadFile(string firstName, string lastName, string fileName)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            string content = $"First Name: {firstName}\nLast Name: {lastName}";

            byte[] fileBytes = Encoding.UTF8.GetBytes(content);

            return File(fileBytes, "text/plain", fileName + ".txt");
        }
    }
}
