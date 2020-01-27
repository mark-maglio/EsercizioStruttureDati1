using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioStruttureDati1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> dati = new List<double>();
            using (StreamReader r = new StreamReader("decimali.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    double n = double.Parse(line);
                    dati.Add(n);
                }
            }
            using (StreamWriter w = new StreamWriter("file.txt", false, Encoding.UTF8))
            {
                for(int i = dati.Count-1 ; i >=0 ; i--)
                {
                    w.WriteLine(dati[i]);
                }
            }
        }
    }
}