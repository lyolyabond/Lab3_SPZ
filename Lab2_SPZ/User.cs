using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_SPZ
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        List<ProgramClass> AvailablePrograms { get; set; }

        public User()
        { 
            AvailablePrograms = new List<ProgramClass>();
        }
        public bool Authentication(string password) => Password == password;
        public static bool operator ==(User user1, User user2) => user1.AvailablePrograms.Count().Equals(user2.AvailablePrograms.Count());
        public static bool operator !=(User user1, User user2) => !user1.AvailablePrograms.Count().Equals(user2.AvailablePrograms.Count());
        public bool AddToAvailablePrograms(ProgramClass program)
        {
            if (!AvailablePrograms.Contains(program))
            {
                AvailablePrograms.Add(program);
                return true;
            }
            else return false;        }
        public bool DeleteProgram(ProgramClass program)
        {
            if(AvailablePrograms.Contains(program))
            { 
            AvailablePrograms.Remove(program);
                return true;
            }
            else return false;
        }
    }
    
}
