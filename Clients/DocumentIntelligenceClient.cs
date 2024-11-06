using Azure;
using System;
using Azure.AI.DocumentIntelligence;
namespace Clients;

public class DocumentIntelligenceClient
{
    public async Task<string> GetFileContentLanguageResult(string uri, UserSecrets secrets)
    {
        return "TODO";

// string endpoint = "<endpoint>";
// var client = new DocumentIntelligenceClient(new AzureKeyCredential(secrets.AzureAIKey));

//         Uri uriSource = new Uri("<uriSource>");

// var content = new AnalyzeDocumentContent()
// {
//     UrlSource = uriSource
// };

// List<DocumentAnalysisFeature> features = new List<DocumentAnalysisFeature>
// {
//     DocumentAnalysisFeature.Languages
// };

// var operation = await client.AnalyzeDocumentAsync(WaitUntil.Completed, "prebuilt-layout", content, features: features);
// AnalyzeResult result = operation.Value;

// return result.Languages[0].Languages[0].Name;









        // var content = new AnalyzeDocumentContent(){ UrlSource = new Uri(uri) };


        // var client = new DocumentIntelligenceClient(new Uri(secrets.DocumentIntelligenceEndpoint), new AzureKeyCredential(secrets.AzureAIKey));
        // var result = client.AnalyzeDocumentAsync("prebuilt-document", new Uri(uri), new DocumentAnalysisOptions()).Result;
        // return result.Documents[0].Languages[0].Name;        
    }
}