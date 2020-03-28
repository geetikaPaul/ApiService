using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApiService.Models
{
    public class Content
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Body { get; set; }
        public String ExtendedBody { get; set; }
    }
}