using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_SPZ
{
    public class ProgramManager : Specifications
    {

        public List<ProgramClass> ListOfInstalledPrograms { get; set; }
        public  Dictionary<string, User> UserDictionary { get; set; }
        public  int NumberOfInstalledPrograms { get; set; }
        public int NumberOfUsers { get; set; }
        public ProgramManager()
        {
            ListOfInstalledPrograms = new List<ProgramClass>();
            UserDictionary = new Dictionary<string, User>();
        }
        public void MethodNumberOfUsers()
        {
            NumberOfUsers++; 
        }
        public void MethodNumberOfInstalledPrograms()
        {
            NumberOfInstalledPrograms++;
        }

        public bool AvailabilityOfUse(ProgramClass program) => program < this;
        public bool ComparePrograms(int index1, int index2)=> ListOfInstalledPrograms[index1] < ListOfInstalledPrograms[index2];
       
        public bool CompareUsers(string userName1, string userName2)=> UserDictionary[userName1] == UserDictionary[userName2];
   
        public void ChangeVersion(ProgramClass program, double version)
        {
           foreach(ProgramClass installedProgram in ListOfInstalledPrograms)
            {
                if(installedProgram == program)
                {
                    installedProgram.ChangeVersion(version);
                    break;
                }
            }
        }
        public void ProgramInstallation(ProgramClass program)
        {
            ListOfInstalledPrograms.Add(program);
            MethodNumberOfInstalledPrograms();
        }
        public bool ProgramDelete(ProgramClass program)
        {
            if (ListOfInstalledPrograms.Contains(program))
            {
                ListOfInstalledPrograms.Remove(program);
                return true;
            }
            else return false;
        }
        public void AddUser(User user)
        {
            if (!UserDictionary.ContainsKey(user.UserName))
            { 
             UserDictionary.Add(user.UserName, user);
                MethodNumberOfUsers();
            }
        }
        public void DeleteUser(string name)
        {
                UserDictionary.Remove(name);
        }
        public void ChangeSpecifications(string OSType, double CPUFrequency, int RAM, double HDDSpace)
        {
            this.OSType = OSType;
            this.CPUFrequency = CPUFrequency;
            this.RAM = RAM;
            this.HDDSpace = HDDSpace;
        }


    }
}
