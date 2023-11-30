using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VisitorCore.Models;
using VisitorWebApi.Models;


namespace VisitorWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VisitorController : Controller
    {
        private VisitorAppContext _context;

        public VisitorController(VisitorAppContext context)
        {
            _context = context;
        }

        [HttpPut]
        public void Put([FromBody] VisitorAddDto model)
        {
            var visitor = new Visitor
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Phone = model.Phone,
                DoctorId = model.DoctorId,
                CreatedAt = DateTime.Now
            };
            _context.Visitors.Add(visitor);
            _context.SaveChanges();

        }


        [HttpPost]
        public void Post(VisitorEditDto visitor)
        {
            var existVisitor = _context.Visitors.FirstOrDefault(x => x.Id == visitor.Id);

            if (existVisitor != null)
            {
                existVisitor.FirstName = visitor.FirstName;
                existVisitor.LastName = visitor.LastName;
                existVisitor.Email = visitor.Email;
                existVisitor.Phone = visitor.Phone;
                existVisitor.DoctorId = visitor.DoctorId;
                existVisitor.UpdatedAt = DateTime.Now;

                _context.Visitors.Update(existVisitor);
                _context.SaveChanges();
            }

        }

        [HttpGet]
        [Route("GetOne")]
        public VisitorGetDto? Get(int id)
        {
            var visitor = _context.Visitors.Include(p => p.Doctor).FirstOrDefault(x => x.Id == id);

            if (visitor == null) return null;

            return VisitorGetDto(visitor);
        }

        [HttpGet]
        [Route("GetAll")]
        public VisitorGetAllDto GetAll()
        {

            var model = new VisitorGetAllDto
            {
                Visitors = _context.Visitors
                    .ToList()
                    .Select(visitor => VisitorGetDto(visitor))
                    .ToList(),
                Doctors = _context.Doctors.ToList()
            };
        
            return model;

        }

        private VisitorGetDto VisitorGetDto(Visitor visitor)
        {
            return new VisitorGetDto
            {
                Id = visitor.Id,
                FirstName = visitor.FirstName,
                LastName = visitor.LastName,
                Email = visitor.Email,
                Phone = visitor.Phone,
                DoctorId = visitor.DoctorId,
                Doctor = visitor.Doctor,
                CreatedAt = visitor.CreatedAt,
                UpdatedAt = visitor.UpdatedAt
            };
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var visitor = _context.Visitors.FirstOrDefault(x => x.Id == id);

            if (visitor != null)
            {
                _context.Visitors.Remove(visitor);
                _context.SaveChanges();
            }

        }
    }
}
