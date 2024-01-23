using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Data.Shared.Models
{
    public class MedicalDoctor : MedicalStaff
    {
        public MedicalDoctor(string firstName, string lastName, int wardId, string telephone, string address, string sIN, string talkieWalkieLine)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            WardId = wardId;
            Telephone = telephone ?? throw new ArgumentNullException(nameof(telephone));
            Address = address ?? throw new ArgumentNullException(nameof(address));
            SIN = sIN ?? throw new ArgumentNullException(nameof(sIN));
            TalkieWalkieLine = talkieWalkieLine ?? throw new ArgumentNullException(nameof(talkieWalkieLine));
        }

        public int WardId { get; set; }
        public UserRoles Role { get; } = UserRoles.MedicalDoctor;
        public List<Guid> Patients { get; set; } = new List<Guid>();
    }
}
