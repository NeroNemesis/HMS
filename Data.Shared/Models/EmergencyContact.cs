using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Shared.Models
{
    public class EmergencyContact
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public Guid RelatedPatient {  get; set; }
        public string RelationshipWithRelatedPatient { get; set; }

        public EmergencyContact(string firstName, string lastName, string telephone, string relationshipWithRelatedPatient)
        {
            RelationshipWithRelatedPatient = relationshipWithRelatedPatient;
            FirstName = firstName;
            LastName = lastName;
            Telephone = telephone;
        }
    }
}
