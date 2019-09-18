using System;
using System.Collections.Generic;
using System.Text;

namespace universityHospital
{
    class Patient
    {
        int health { get; set; }
        int blood { get; set; }

        public Patient()
        {
            this.health = 10;
            this.blood = 20;
        }
    }
}
