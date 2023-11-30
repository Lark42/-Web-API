using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisitorCore.Models
{
    public class VisitorGetDto
    {
        public int Id { get; set; }

        public int DoctorId { get; set; }

        public Doctor? Doctor { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public DateTime CreatedAt {  get; set; }
        
        public DateTime UpdatedAt { get; set;}
    }
}
