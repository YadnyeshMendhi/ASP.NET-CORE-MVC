using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

namespace ASPNetCoreMVC.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        
        [Display(Name ="First Name")]
        [Column(TypeName="nvarchar(12)")]
        public string FirstName { get; set; }

     
        [Display(Name = "Last Name")]
        [Column(TypeName ="nvarchar(100)")]
        public string LastName { get; set; }

        [Display(Name = "Contact Number")]
        [Column(TypeName = "nvarchar(100)")]
        public string ContactNumber { get; set; }

        
        [Display(Name = "City")]
        [Column(TypeName ="nvarchar(11)")]
        public string City { get; set; }

        [Display(Name = "State")]
        [Column(TypeName ="nvarchar(11)")]
        public string State { get; set; }

        public DateTime Date { get; set; }
    }
}