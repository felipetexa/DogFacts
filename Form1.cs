using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace DogFacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void getRandomDogFacts_Click(object sender, EventArgs e)
        {
            string randomDogFactsApiUrl = "https://dog-api.kinduff.com/api/facts";

            try
            {
                string response = await ConsumeApi(randomDogFactsApiUrl);

                string[] facts = ExtractFactsFromApi(response);

                MessageBox.Show(string.Join(Environment.NewLine, facts), "Random dog fact", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<string> ConsumeApi(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }

        private string[] ExtractFactsFromApi(string response)
        {
            using (JsonDocument doc = JsonDocument.Parse(response))
            {
                JsonElement root = doc.RootElement;
                if (root.TryGetProperty("facts", out JsonElement factsElement) && factsElement.ValueKind == JsonValueKind.Array)
                {
                    string[] facts = new string[factsElement.GetArrayLength()];
                    int index = 0;
                    foreach (JsonElement fact in factsElement.EnumerateArray())
                    {
                        facts[index++] = fact.GetString();
                    }
                    return facts;
                }
                else
                {
                    return new string[] { "Facts attribute not found or it is not an array" };
                }
            }
        }
    }
}
