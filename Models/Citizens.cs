using System;
namespace Election10.Models
{
    public class Citizens
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int PIN { get; set; }
    }
}