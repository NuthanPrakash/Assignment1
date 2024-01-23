using System.ComponentModel.DataAnnotations;

namespace SBShared.Models
{
    [Serializable]
    public class PersonModel
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
    }
}
