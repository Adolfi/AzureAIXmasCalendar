using Azure;
using System;
using Azure.AI.TextAnalytics;
namespace Clients;

public class TextAnalyticsClient
{
    public string GetTextSummarizationResult(string text, UserSecrets secrets)
    {
        TextAnalyticsClient client = new TextAnalyticsClient(new Uri(secrets.LanguageEndpoint), new AzureKeyCredential(secrets.AzureAIKey));
        TextAnalyticsActions actions = new TextAnalyticsActions() { ExtractiveSummarizeActions = new List<ExtractiveSummarizeAction>() { new ExtractiveSummarizeAction() } };
        AnalyzeActionsOperation operation = await client.StartAnalyzeActionsAsync(new List<string> { text }, actions);
        await operation.WaitForCompletionAsync();

        return operation.Value.ExtractiveSummarizeResults[0].Summaries[0].Text;
    }
}