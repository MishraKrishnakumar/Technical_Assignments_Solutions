using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAPIProject

{  //creating a class called “PostData” that will represent the data we want to send to the API as a JSON object.
    public class PostData
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
