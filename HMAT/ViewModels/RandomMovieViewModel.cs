using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HMAT.Models;

namespace HMAT.ViewModels
{
    public class RandomMovieVieweModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; } 

    }
}
