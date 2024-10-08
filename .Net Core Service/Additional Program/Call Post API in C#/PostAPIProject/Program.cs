using System;
using System.Text;
using System.Text.Json;

namespace PostAPIProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //creating a new class instance and populate it with the data we want to send to the API.

            var postData = new PostData
            {
                Name = "Krishnakumar Mishra",
                Age = 32,
                Address = "Ahmedabad"
            };

            //creating a new HttpClient object, allowing us to make the POST request.

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");

            var json = System.Text.Json.JsonSerializer.Serialize(postData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Make the actual POST request by calling the HttpClient’s “PostAsync” method.

            var response = client.PostAsync("posts", content).Result;

            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                // Read the response content and use the System.Text.Json namespace to deserialize it back to a C# object.

                var postResponse = System.Text.Json.JsonSerializer.Deserialize<PostResponse>(responseContent, options);
                Console.WriteLine("Post successful! ID: " + postResponse.Id);

            }
            else
            {
                Console.WriteLine("Error: " + response.StatusCode);
            }
        }
    }
}