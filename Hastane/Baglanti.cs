using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    internal class Baglanti
    {
        static string yol = File.ReadAllText(@"C:\test.txt");
        public static string baglantiAdres = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+yol+@"\Hastane_DB.mdf;Integrated Security=True;Connect Timeout=30";
    }
}
