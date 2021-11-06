using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_SPZ
{
    public class ProgramClass : Specifications
    {
        public string ProgramName { get; set; }
        public string Manufacturer { get; set; }
        public DateTime InstallationDate { get; set; }
        public double Version { get; set;}


        public ProgramClass()
        { }
        public ProgramClass(string programName, string OSType, string manufacturer,
            DateTime installationDate, double version, int RAM, 
            double CPUFrequency, double HDDSpace) : base(OSType, CPUFrequency, RAM, HDDSpace)
        {
            ProgramName = programName;
            Manufacturer = manufacturer;
            InstallationDate = installationDate;
            Version = version;
        }
        public void ChangeVersion(double version)
        {
            Version = version;
        }

        public static bool operator >(ProgramClass specifications1, Specifications specifications2)
        {
            return specifications1.HDDSpace > specifications2.HDDSpace ||
                specifications1.CPUFrequency > specifications2.CPUFrequency ||
                specifications1.OSType != specifications2.OSType ||
                specifications1.RAM > specifications2.RAM;
        }
        public static bool operator <(ProgramClass specifications1, Specifications specifications2)
        {
            return specifications1.HDDSpace <= specifications2.HDDSpace &&
               specifications1.CPUFrequency <= specifications2.CPUFrequency &&
               specifications1.OSType == specifications2.OSType &&
               specifications1.RAM <= specifications2.RAM;
        }

    }
}
