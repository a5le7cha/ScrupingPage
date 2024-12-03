using Krista;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Npgsql;

async static Task<JToken> GetReply()
{
    JToken jobject;
    string request = "https://budget.gov.ru/epbs/registry/ubpandnubp/data";
    HttpClient httpClient = new HttpClient();
    HttpResponseMessage response = await httpClient.GetAsync(request);

    string stringData = await response.Content.ReadAsStringAsync();
    jobject = JObject.Parse(stringData);
    return jobject;
}
ILogger<Program> logger = null;

JArray jarray = null;
JToken objJson = await GetReply();
foreach (JToken item in objJson.Children())
{
    if (item.Path == "data")
        jarray = (JArray)item.Last;
}

/*foreach (JToken dat in jarray)
{
    Console.Clear();
    Console.WriteLine(dat);
    Console.ReadKey();
}
Console.ReadKey();*/

string connectionString = "Host=localhost;Port=5433;Database=postgres;Username=postgres;Password=1234";

//Root dbRoot = JsonConvert.DeserializeObject<Root>(jarray.ToString());

/*using (ApplicationContextDB db = new ApplicationContextDB())
{
    Root r = new Root();
    db.root.Add(r);
    db.SaveChanges();
}*/

SQLCommand("CREATE TABLE()", ConnectionDB(connectionString), logger);

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