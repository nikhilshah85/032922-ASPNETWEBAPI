using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
namespace consume_WebAPI.Models
{
    public class Albums
    {

        public int userId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }


        public List<Albums> GetAlbumList()
        {
            HttpClient client = new HttpClient();
            string url = "https://jsonplaceholder.typicode.com/posts";

            client.DefaultRequestHeaders.Accept.Clear(); //different browsers makes api calls in different formats, we will want calls to be made in JSON
                                                         //eg. chrome has a default format as XML, IE has JSON, some app has text, binary
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));          
            
            var call = client.GetAsync(url);
            var response = call.Result;
            List<Albums> albumlist = new List<Albums>();

            if (response.IsSuccessStatusCode)
            {
                var read = response.Content.ReadAsAsync<List<Albums>>();
             //   var read = response.Content.ReadAsStringAsync<List<Albums>>();
                read.Wait();

                albumlist = read.Result;
            }
            return albumlist;

        }
    }
}
