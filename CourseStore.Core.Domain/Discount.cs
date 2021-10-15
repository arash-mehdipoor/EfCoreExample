using System.ComponentModel.DataAnnotations.Schema;

namespace CourseStore.Core.Domain
{
    //[NotMapped]
    public class Discount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NewPrice { get; set; }
        public int CourseId { get; set; }
    }
}
