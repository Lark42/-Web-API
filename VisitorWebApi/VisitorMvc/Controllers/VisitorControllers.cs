using Microsoft.AspNetCore.Mvc;
using VisitorCore.Models;
using VisitorMvc.Models;
using System.Reflection;


namespace VisitorMvc.Controllers
{
    public class VisitorController : Controller
    {
        public async Task<IActionResult> Index()
        {

            using HttpClient client = new HttpClient();

            var model = await client.GetFromJsonAsync<VisitorGetAllDto>("http://localhost:5301/Visitor/GetAll");

            return View(model);
        }
        public async Task<IActionResult> Delete(int id)
        {

            using HttpClient client = new HttpClient();

            var model = await client.DeleteAsync($"http://localhost:5301/Visitor?id={id}");

            return RedirectToAction(nameof(Index));

        }

        [HttpPost]
        public async Task<IActionResult> Add(string name, string lastName, int doctorId, string Email, string Phone)
        {

            using HttpClient client = new HttpClient();

            var visitor = new VisitorAddDto { DoctorId = doctorId, FirstName = name, LastName = lastName, Email = Email, Phone = Phone };

            await client.PutAsJsonAsync($"http://localhost:5301/Visitor", visitor);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            using HttpClient client = new HttpClient();

            var model = await client.GetFromJsonAsync<List<Doctor>>("http://localhost:5301/Doctor/GetAll");

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(VisitorEditDto visitor)
        {

            using HttpClient client = new HttpClient();

            await client.PostAsJsonAsync($"http://localhost:5301/Visitor", visitor);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            using HttpClient client = new HttpClient();

            var model = new VisitorEditViewModel
            {
                Visitor = await client.GetFromJsonAsync<VisitorGetDto>($"http://localhost:5301/Visitor/GetOne?id={id}"),

                Doctors = await client.GetFromJsonAsync<List<Doctor>>("http://localhost:5301/Doctor/GetAll")

            };

            return View(model);

        }
    }
}
