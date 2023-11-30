using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VisitorCore.Models
{
    public class VisitorEditDto
    {
       
        public int Id { get; set; }
                
        public int DoctorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }
        
    }
}
