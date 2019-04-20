using System;
namespace Election10.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public int NumberInTheList { get; set; }

        public int ElectionId { get; set; }
        public Election Election { get; set; }

        public int CitizensId { get; set; }
        public Citizens Citizens { get; set; }

}
}
