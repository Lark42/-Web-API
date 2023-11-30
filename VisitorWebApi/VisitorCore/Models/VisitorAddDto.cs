namespace VisitorCore.Models
{
    public class VisitorAddDto
    {            

        public int DoctorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }
    }
}
