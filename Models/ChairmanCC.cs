using System;
namespace Election10.Models
{
    public class ChairmanCC
    {
        public int Id { get; set; }

        public int ElectionId { get; set; }
        public Election Election { get; set; }

        public int VirtualCantonId { get; set; }
        public VirtualCanton VirtualCanton { get; set; }

        public int CitizensId { get; set; }
        public Citizens Citizens { get; set; }
    }
}
