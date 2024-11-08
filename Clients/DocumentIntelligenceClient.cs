using Azure;
using Azure.AI.DocumentIntelligence;
namespace Clients;

public class DocumentIntelligenceClient
{
    public async Task<string> GetFileContentLanguageResult(string uri, UserSecrets secrets)
    {
		Azure.AI.DocumentIntelligence.DocumentIntelligenceClient client = new(new Uri(secrets.DocumentIntelligenceEndpoint!), new AzureKeyCredential(secrets.AzureAIKey!));
        var operation = await client.AnalyzeDocumentAsync(WaitUntil.Completed, "prebuilt-layout", new AnalyzeDocumentContent() { UrlSource = new Uri(uri) }, features: new List<DocumentAnalysisFeature> { DocumentAnalysisFeature.Languages });

        var language = operation.Value.Languages.OrderByDescending(result => result.Confidence)?.FirstOrDefault();
        return $"The document language is '{language?.Locale}' with a confidence score of {language?.Confidence}.";
    }
}