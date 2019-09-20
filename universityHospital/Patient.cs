using System;
using System.Collections.Generic;
using System.Text;

namespace universityHospital
{
    public class Patient
    {
        public int health { get; set; }
        public int blood { get; set; }

        public Patient()
        {
            this.health = 10;
            this.blood = 20;
        }
    }
}
