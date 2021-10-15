namespace CourseStore.Core.Domain
{
    public class Person
    {
        public int Id { get; set; }
        //public string Name { get; set; }
        //public string LastName { get; set; }

        public string FullName { get; set; }
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
