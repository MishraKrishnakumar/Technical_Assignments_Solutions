using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAPIProject
{
    // creating a class called “PostResponse” that will represent the response we get from the API.
    public class PostResponse
    {
        public int Id { get; set; }   //property “Id” which will hold the Id of the newly created resource.
    }
}
