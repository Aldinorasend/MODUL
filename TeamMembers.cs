using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace MODUL7_KELOMPOK_4
{
    internal class TeamMembers
    {
        public void ReadJSON()
        {
            string jsonData = File.ReadAllText(@"D:\C# Project\MODUL7_KELOMPOK_4\jurnal7_2_1302223071.json");
            Anggota mahasiswa = JsonConvert.DeserializeObject<Anggota>(jsonData);

            

            foreach (var member in mahasiswa.members)
            {
                Console.WriteLine($"<{member.nim}> <{member.firstname} {member.lastname}> ({member.age} {member.gender})");
            
    
            }
        }

        public class Anggota
        {
        
            public List<Member> members { get; set; }


        }
        public class Member
        {
            public string firstname { get; set; }
            public string lastname { get; set; }

            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }
        }
    }
}