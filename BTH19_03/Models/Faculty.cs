using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BTH19_03.Models;

 [Table("Faculty")]
public class Faculty{
    [Key]
    public string FacultyID {get;set;}
    public string FacultyName {get;set;}
}