using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Shared.Models
{
    public class Nurse : MedicalStaff
    {
        public string TalkieWalkieLine { get; set; }
        public Nurse(string firstName, string lastName, int assignedWard, string telephone, string address, string sIN, string talkieWalkieLine)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            AssignedWard = assignedWard;
            Telephone = telephone ?? throw new ArgumentNullException(nameof(telephone));
            Address = address ?? throw new ArgumentNullException(nameof(address));
            SIN = sIN ?? throw new ArgumentNullException(nameof(sIN));
            TalkieWalkieLine = talkieWalkieLine;
        }

        public int AssignedWard { get; set; }
        public UserRoles Role { get; } = UserRoles.Nurse;
    }
}
