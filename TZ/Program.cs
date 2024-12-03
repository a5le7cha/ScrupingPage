using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Npgsql;
using Microsoft.Extensions.Logging;
using ClickHouse;

namespace TZ
{
    class Program
    {
        public static JToken jobject;

        async static Task<JToken> GetReply()
        {
            string request = "https://budget.gov.ru/epbs/registry/ubpandnubp/data";
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(request);

            string stringData = await response.Content.ReadAsStringAsync();
            jobject = JObject.Parse(stringData);
            return jobject;
        }

        async static Task Main(string[] args)
        {
            JArray jarray = null;
            JToken objJson = await GetReply();
            foreach(JToken item in objJson.Children())
            {
                if (item.Path == "data")
                    jarray = (JArray)item.Last;
            }

            foreach (JToken dat in jarray)
            {
                Console.Clear();
                Console.WriteLine(dat);
                Console.ReadKey();
            }
            Console.ReadKey();

            string connectionString = "Host=localhost;Port=5433;Database=postgres;Username=postgres;Password=1234";
        }

        NpgsqlConnection ConnectionDB(string connectionString)
        {
            return new NpgsqlConnection(connectionString);
        }

        static void SQLCommand(string sqlCom, NpgsqlConnection con, ILogger<Program> logger)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand(sqlCom, con);

            try
            {
                con.Open();
                logger.LogInformation("Connection DB...");
            }
            catch (Exception ex)
            {
                logger.LogError($"Error DB: {ex.Message}");
            }
            finally
            {
                con.Close();
                logger.LogInformation("Disconnection DB");
            }
        }
    }
}