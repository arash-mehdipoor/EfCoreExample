using System;

namespace CourseStore.Core.Domain
{

    public class NationalCode
    {
        public string Value { get; set; }

        public NationalCode(string nationalCode)
        {
            // cheking NationalCode
            Value = nationalCode;
        }
    }

    public class PersonName
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }

    public class PersonValueConvesion
    {
        public int Id { get; set; }
        public PersonName Name { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public PersonType PersonType { get; set; }
        public NationalCode NationalCode { get; set; }
    }
}
