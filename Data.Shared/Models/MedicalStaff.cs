using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Shared.Models
{
    public class MedicalStaff
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public String Telephone { get; set; }
        public string Address { get; set; }
        public string SIN { get; set; }
        public string RegistrationCode { get; set; }
        public string TalkieWalkieLine { get; set; }
    }
}
