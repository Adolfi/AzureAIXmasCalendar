using Azure;
using Azure.AI.TextAnalytics;

namespace Clients;

public class LanguageClient
{
    public async Task<string> GetTextSummarizationResultAsync(string text, UserSecrets secrets)
    {
		TextAnalyticsClient client = new TextAnalyticsClient(new Uri(secrets.LanguageEndpoint!), new AzureKeyCredential(secrets.AzureAIKey!));
        TextAnalyticsActions actions = new TextAnalyticsActions() { AbstractiveSummarizeActions = new List<AbstractiveSummarizeAction>() { new AbstractiveSummarizeAction() } };
        AnalyzeActionsOperation operation = await client.StartAnalyzeActionsAsync(new List<string> { text }, actions);
        await operation.WaitForCompletionAsync();

        return SummarizePagedResult(operation.GetValues());
    }

    private string SummarizePagedResult(Pageable<AnalyzeActionsResult> results)
    {
        var summary = string.Empty;
        foreach (var result in results)
        {
			foreach (var abstractiveSummarizeResults in result.AbstractiveSummarizeResults)
			{
				foreach (var documentsResults in abstractiveSummarizeResults.DocumentsResults)
				{
					foreach (var summaries in documentsResults.Summaries)
					{
                        summary += summaries.Text;
					}
				}
			}
		}
        return summary;
    }
}