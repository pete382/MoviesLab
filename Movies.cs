using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLab
{
    public class Movie
    {
        public string title { get; set; }
        public string category { get; set; }


        //Constructor
        public Movie(string _title, string _category) 
        {
            title = _title;
            category = _category;
        }


        //Methods
        public Movie()
        {
        }


       



    }
}
