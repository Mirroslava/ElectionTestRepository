﻿using System;
namespace Election10.Models
{
    public class Watcher
    {
       public int Id { get; set; }

        public int ElectionId { get; set; }
        public Election Election { get; set; }

        public int VirtualCantonId { get; set; }
        public VirtualCanton VirtualCanton { get; set; }

        public int CandidateId{ get; set; }
        public Candidate Candidate { get; set; }

        public int CitizensId{ get; set; }
        public Citizens Citizens { get; set; }
    }
}
