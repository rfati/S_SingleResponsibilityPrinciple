using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            FilmCrud fc = new FilmCrud();
            FilmDef f = new FilmDef();
            FilmProcess fp = new FilmProcess();
            
            f.NAME = "Can Dostum";
            f.CATEGOTY = false;
            f.GENRE = "Komedi";
            f.PATH = "c:\\imageFolder";
            f.POINT = (float)7.7;
            
            fc.FilmAdd(f);
            fc.FilmList();
            fp.Process();

            Console.Read();
        }
    }
}
