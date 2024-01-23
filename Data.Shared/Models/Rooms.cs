using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Shared.Models
{
    public class Room
    {
        public Room()
        {
            Patients = new List<Guid>(Capacity);
        }

        public int Id { get; set; }
        public int WardId { get; set; }
        public int Capacity { get; }
        public List<Guid> Patients { get; set; }
    }
}
