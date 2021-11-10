using System.ComponentModel.DataAnnotations;

namespace WebApplication.DataAccess
{
    public class Course
    {
        [Key, MaxLength(7)]
        public string Id { get; set; }
        [Required, MaxLength(256)]
        public string Name { get; set; }
        [Range(1,7, ErrorMessage = "ErrorMessage in Course")]
        public int Semester { get; set; }
        [Required]
        public bool IsElective { get; set; }

        public string ToString()
        {
            return "ID: " + Id + "\\n" +
                   "\\t Name: " + Name + "\\n" + 
                   "\\t Semester: " + Semester + "\\n" +
                   "\\t IsElective: " + IsElective.ToString();
        }
    }
}