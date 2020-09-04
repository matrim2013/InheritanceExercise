﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class

        public string Species { get; set; }
        public bool Flight { get; set; }
        public string Sound { get; set; }
        public int WingSpan { get; set; }

    }
}
