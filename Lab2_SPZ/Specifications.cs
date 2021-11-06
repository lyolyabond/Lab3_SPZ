using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_SPZ
{
    public abstract class Specifications
    {
        public string OSType { get; set; }
        public double CPUFrequency { get; set; }
        public int RAM { get; set; }
        public double HDDSpace { get; set; }
        protected Specifications(){}
        protected Specifications(string OSType, double CPUFrequency, int RAM, double HDDSpace)
        {
            this.OSType = OSType;
            this.CPUFrequency = CPUFrequency;
            this.RAM = RAM;
            this.HDDSpace = HDDSpace;

        }
    }
}
