using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Shared.Models
{
    public class ChargeNurse : MedicalStaff
    {
        public ChargeNurse(string firstName, string lastName, int wardId, string telephone, string talkieWalkieLine, string address, string sIN)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            WardId = wardId;
            Telephone = telephone ?? throw new ArgumentNullException(nameof(telephone));
            TalkieWalkieLine = talkieWalkieLine ?? throw new ArgumentNullException(nameof(talkieWalkieLine));
            Address = address ?? throw new ArgumentNullException(nameof(address));
            SIN = sIN ?? throw new ArgumentNullException(nameof(sIN));
        }

        public int WardId { get; set; }
        public UserRoles Role { get; } = UserRoles.ChargeNurse;
    }
}
