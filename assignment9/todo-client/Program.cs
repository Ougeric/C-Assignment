using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using TodoApi.Models;

namespace todo_client {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            string baseUrl = "https://localhost:7053/api/todo";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            TodoItem todo = new TodoItem() { Id = 50, Name = "软件构造基础", IsComplete = false };
            HttpContent content = new StringContent(JsonConvert.SerializeObject(todo), Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content);
            task.Wait();

            var task2 = client.GetStringAsync(baseUrl);
            List<TodoItem> todos = JsonConvert.DeserializeObject<List<TodoItem>>(task2.Result);
            todos.ForEach(t => Console.WriteLine($"{t.Id},{t.Name},{t.IsComplete}"));
        }
    }
}