using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Shared.Models
{
    public class Patient
    {
        public Patient(string firstName, string lastName, string address, string telephone, DateOnly dateOfBirth, string gender, string maritalStatus, Guid externalDoctorId, string healthCardId)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Address = address ?? throw new ArgumentNullException(nameof(address));
            Telephone = telephone ?? throw new ArgumentNullException(nameof(telephone));
            DateOfBirth = dateOfBirth;
            Gender = gender ?? throw new ArgumentNullException(nameof(gender));
            MaritalStatus = maritalStatus ?? throw new ArgumentNullException(nameof(maritalStatus));
            ExternalDoctorId = externalDoctorId;
            HealthCardId = healthCardId ?? throw new ArgumentNullException(nameof(healthCardId));
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public Guid ExternalDoctorId { get; set; }
        public string HealthCardId { get; set; }
        public Guid EmergencyContactId { get; set; }
    }
}
