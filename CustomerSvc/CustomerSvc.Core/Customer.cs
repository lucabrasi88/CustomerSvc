using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace CustomerSvc.Core
{
    /// <summary>
    /// Data contract for Customer data
    /// </summary>
    [DataContract]
    public class Customer
    {
        /// <summary>
        /// Id
        /// </summary>
        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Customer's first name
        /// </summary>
        [DataMember]
        [MaxLength(30), Required]
        public string Name { get; set; }

        /// <summary>
        /// Customer's surname
        /// </summary>
        [DataMember]
        [MaxLength(60), Required]
        public string Surname { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        [DataMember]
        [RegularExpression(@"^\d{1,12}$", ErrorMessage = "Please enter up to 12 digits for a contact number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        [DataMember]
        public string Address { get; set; }

        /// <summary>
        /// Customer's number
        /// </summary>
        [DataMember]
        [Required]
        [Key]
        public string CustomerNumber { get; set; }
    }

}
