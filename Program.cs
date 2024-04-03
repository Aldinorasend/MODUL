using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPMODUL7_KELOMPOK_4;

namespace MODUL7_KELOMPOK_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_1302220108 dataMahasiswa = new DataMahasiswa_1302220108();
            dataMahasiswa.ReadJSON();
            Console.ReadLine();
        }
    }
}
