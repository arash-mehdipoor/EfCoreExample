using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseStore.Core.Domain
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public int Price { get; set; }
        [Required]
        [MaxLength(250,ErrorMessage ="")]
        public string Description { get; set; }
        public Discount Discount { get; set; }
        public List<Tag> Tags { get; set; }
        public List<CourseTeacher> CourseTeachers { get; set; }
        public List<Comment> Comments { get; set; }
        public bool IsDeleted { get; set; }
    }

    //public class LazyCourse
    //{
    //    public int Id { get; set; }
    //    public string Title { get; set; }
    //    public int Price { get; set; }
    //    public string Description { get; set; }
    //    public virtual Discount Discount { get; set; }
    //    public virtual List<Tag> Tags { get; set; }
    //    public virtual List<CourseTeacher> CourseTeachers { get; set; }
    //    public virtual List<Comment> Comments { get; set; }
    //}
}
