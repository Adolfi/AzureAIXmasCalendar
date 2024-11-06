using Azure;
using Azure.AI.Vision.ImageAnalysis;
using System;
namespace Clients;

public class VisionClient
{
    public string GetImageCaptionResult(string url, UserSecrets secrets)
    {
        ImageAnalysisClient client = new ImageAnalysisClient(new Uri(secrets.VisionEndpoint), new AzureKeyCredential(secrets.AzureAIKey));
        ImageAnalysisResult result = client.Analyze(new Uri(url), VisualFeatures.Caption, new ImageAnalysisOptions { GenderNeutralCaption = true });
        return result.Caption.Text;
    }
}