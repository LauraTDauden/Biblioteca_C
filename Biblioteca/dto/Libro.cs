using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.dto
{
    class Libro
    {
        public String ISBN { get; set; }
        public String title { get; set; }
        public String author { get; set; }
        public String publisher { get; set; }
        public String subject { get; set; }
        public String condition { get; set; }
        public Libro()
        {

        }
    }
}
