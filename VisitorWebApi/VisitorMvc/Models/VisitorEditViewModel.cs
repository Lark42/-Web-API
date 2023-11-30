using System.Text.RegularExpressions;
using VisitorCore.Models;


namespace VisitorCore.Models
{
    public class VisitorEditViewModel
    {
        public VisitorGetDto? Visitor { get; set; }

        public List<Doctor>? Doctors { get; set; }
    }
}
