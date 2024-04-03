using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL7_KELOMPOK_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_1302223146 dataMahasiswa = new DataMahasiswa_1302223146();
            dataMahasiswa.ReadJSON();
            Console.ReadLine();

            TeamMembers_1302223146 teammembers = new TeamMembers_1302223146();
            teammembers.ReadJSON();
            Console.ReadLine();
        }
    }
}
