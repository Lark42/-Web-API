namespace VisitorCore.Models
{
    public class VisitorGetAllDto
    {
        public List <VisitorGetDto> Visitors { get; set; }

        public List <Doctor> Doctors { get; set; }
    }
}
