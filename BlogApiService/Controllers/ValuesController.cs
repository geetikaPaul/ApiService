using BlogApiService.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BlogApiService.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Content> Get()
        {
            List<Content> contents = new List<Content>();
            int id = 0;
            foreach (string file in Directory.EnumerateFiles("C:\\Users\\gpaul3\\reactRedux\\blog", "*.txt"))
            {
                string content = File.ReadAllText(file);
                if (content.Length > 1000)
                {
                    String body = content.Substring(0, 1000);
                    String extendedBody = content.Substring(content.Length - (content.Length - 1000));

                    contents.Add(new Content() { Id = ++id, Body = body, ExtendedBody = extendedBody, Title = Path.GetFileName(file) });
                }
                else
                    contents.Add(new Content() { Id = ++id, Body = content, ExtendedBody = "", Title = Path.GetFileName(file) });
            }

            return contents;
                //new List<Content>() { new Content() { Id = 1, Body = "body 1", ExtendedBody = "Extended body 1", Title = "title1" },
           // new Content() { Id = 2, Body = "body 2", ExtendedBody = "Extended body 2", Title = "title2" } };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
