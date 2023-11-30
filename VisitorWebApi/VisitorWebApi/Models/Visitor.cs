using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using VisitorCore.Models;

namespace VisitorWebApi.Models
{
    public class Visitor
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Doctor))]
        public int DoctorId { get; set; }

        public Doctor? Doctor { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? Phone { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
