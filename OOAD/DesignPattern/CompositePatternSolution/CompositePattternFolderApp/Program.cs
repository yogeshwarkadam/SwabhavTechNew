using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattternFolderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder movies = new Folder("Movies");
            movies.AddChild(new File("spider-man", "500mb"));

            Folder comedy = new Folder("comedy");
            movies.AddChild(comedy);
            movies.AddChild(new File("Golmal", "900mb"));
            movies.Display();
        }
    }
}
