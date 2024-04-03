using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL7_KELOMPOK_4
{
    internal class DataMahasiswa_1302223146
    {
        public void ReadJSON()
        {
            string jsonData = File.ReadAllText(@"C:\Users\alienware\source\repos\MODUL7_KELOMPOK_4\jurnal7_1_1302223146.json");
            Mahasiswa mahasiswa = JsonConvert.DeserializeObject<Mahasiswa>(jsonData);

            Console.WriteLine($"Nama: {mahasiswa.firstName} {mahasiswa.lastName}, Gender: {mahasiswa.gender}, Age: {mahasiswa.age}, Alamat: {mahasiswa.address.streetAddress}, {mahasiswa.address.city}, {mahasiswa.address.state}");
            
            foreach (var course in mahasiswa.courses)
            {
                Console.WriteLine($"Code: {course.code}, Name: {course.name}");
            }
        }
    }
    public class Mahasiswa
    {
        public address address { get; set; }
        public List<Courses> courses { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    public class address
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
    

