using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace MODUL7_KELOMPOK_4
{
    internal class DataMahasiswa_1302223071
    {
        public void ReadJSON()
        {
            string jsonData = File.ReadAllText(@"D:\C# Project\MODUL7_KELOMPOK_4\jurnal7_1_1302223071.json");
            Mahasiswa mahasiswa = JsonConvert.DeserializeObject<Mahasiswa>(jsonData);

            Console.WriteLine($"{mahasiswa.firstname} {mahasiswa.lastname} {mahasiswa.gender} {mahasiswa.age} {mahasiswa.address.streetAddress} Kota {mahasiswa.address.city} Wilayah {mahasiswa.address.state}");

            foreach (var course in mahasiswa.courses)
            {
                Console.WriteLine($"Code: {course.code}, {course.name}");
            }
        }



        public class Mahasiswa
        {
            public String firstname { get; set; }
            public String lastname { get; set; }
            public String gender { get; set; }
            public int age { get; set; }
            public Address address { get; set; }
            public List<Courses> courses { get; set; }


    }



    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class Courses
    {
            public string code { get; set; }
            public string name { get; set; }
    }
            
        


    }
}
    
