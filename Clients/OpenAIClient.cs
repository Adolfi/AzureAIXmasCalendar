using Azure;
using Azure.AI.OpenAI;
using Azure.AI.OpenAI.Images;
using OpenAI.Chat;
using OpenAI.Images;

namespace Clients;

public class OpenAIClient
{
    public string GetChatResult(string message, UserSecrets secrets)
    {
        var azureClient = new AzureOpenAIClient(new Uri(secrets.OpenAIEndpoint), new System.ClientModel.ApiKeyCredential(secrets.AzureAIKey));
        ChatCompletion completion = azureClient.GetChatClient(secrets.OpenAIDeployment).CompleteChat([new UserChatMessage(message)]);
        return completion.Content[0].Text;
    }

    public async Task<Uri> GenerateImageAsync(string description, UserSecrets secrets)
    {
        var azureClient = new AzureOpenAIClient(new Uri(secrets.OpenAIEndpoint), new System.ClientModel.ApiKeyCredential(secrets.AzureAIKey));
        var client = azureClient.GetImageClient(secrets.OpenAIImageDeployment);

        var imageResult = await client.GenerateImageAsync(description, new()
        {
            Quality = GeneratedImageQuality.Standard,
            Size = GeneratedImageSize.W1024xH1024,
            ResponseFormat = GeneratedImageFormat.Uri
        });

        return imageResult.Value.ImageUri;
    }
}