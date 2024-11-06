using System.Text;
using Newtonsoft.Json;
namespace Clients;

public class TranslatorClient
{    
    public async Task<string> GetTranslateResult(string textToTranslate, string from, string to, UserSecrets secrets)
    {
        object[] body = new object[] { new { Text = textToTranslate } };
        var requestBody = JsonConvert.SerializeObject(body);

        using (var client = new HttpClient())
        using (var request = new HttpRequestMessage())
        {
            request.Method = HttpMethod.Post;
            request.RequestUri = new Uri($"{secrets.TranslatorEndpoint}/translate?api-version=3.0&from={from}&to={to}");
            request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
            request.Headers.Add("Ocp-Apim-Subscription-Key", secrets.AzureAIKey);
            request.Headers.Add("Ocp-Apim-Subscription-Region", secrets.TranslatorRegion);
            HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
            return await response.Content.ReadAsStringAsync();
        }
    }
}