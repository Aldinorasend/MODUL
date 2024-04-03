using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL7_KELOMPOK_4
{
    internal class TeamMembers_1302223146
    {
        public void ReadJSON()
        {
            string jsonData = File.ReadAllText(@"C:\Users\alienware\source\repos\MODUL7_KELOMPOK_4\jurnal7_2_1302223146.json");
            TeamList teams = JsonConvert.DeserializeObject<TeamList>(jsonData);

            Console.WriteLine("Team Members List:");
            foreach (var members in teams.members)
            {
                Console.WriteLine($"{members.nim}, {members.firstName} {members.lastName}, {members.age}, {members.gender} ");
            }
        }
    }
    public class TeamList
    {
        public List<Members> members { get; set; }
    }

    public class Members
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }
}