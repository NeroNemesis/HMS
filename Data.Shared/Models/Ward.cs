using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Shared.Models
{
    public class Ward
    {
        public int Id { get; }
        public string Name { get; }
        public Guid ChargeNurseId { get; set; }
        public string Location { get; }
        public string TelephoneExt { get; }
        public int TotalbedsNumber { get; set; }
        public bool WardIsFull { get; set; }
        public List<Guid> PatientsWaitingList { get; set; } = new List<Guid>();
        public List<Guid> PatientList { get; set; } = new List<Guid>();
        public List<Guid> NursesList { get; set; } = new List<Guid>();
        public List<Guid> MedicalDoctorsList { get; set; } = new List<Guid>();
        public List<int> Rooms { get; set; } = new List<int>();
    }
}
