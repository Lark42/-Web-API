using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VisitorCore.Models;
using VisitorWebApi.Models;


namespace VisitorWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctorController : Controller
    {
        private VisitorAppContext _context;

        public DoctorController(VisitorAppContext context)
        {
            _context = context;
        }

        [HttpPut]
        public void Put([FromBody] Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();

        }


        [HttpPost]
        public void Post(Doctor doctor)
        {
            var existDoctor = _context.Doctors.AsNoTracking().FirstOrDefault(x => x.Id == doctor.Id);

            if (existDoctor != null)
            {
                _context.Doctors.Update(doctor);
                _context.SaveChanges();
            }

        }

        [HttpGet]
        [Route("GetOne")]
        public Doctor? Get(int id)
        {
            return _context.Doctors.FirstOrDefault(x => x.Id == id);

        }

        [HttpGet]
        [Route("GetAll")]
        public List<Doctor> GetAll()
        {
            return _context.Doctors.ToList();

        }

        [HttpDelete]
        public void Delete(int id)
        {
            var doctor = _context.Doctors.FirstOrDefault(x => x.Id == id);

            if (doctor != null)
            {
                _context.Doctors.Remove(doctor);
                _context.SaveChanges();
            }

        }
    }
}
