using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseStore.Core.Domain
{
    public class Tag
    {
        public int Id { get; set; }
        
        //[NotMapped]
        public string Title { get; set; }
        
        public List<Course> Courses { get; set; }
    }
}
