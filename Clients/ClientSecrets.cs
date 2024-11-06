using Microsoft.Extensions.Configuration;
namespace Clients;

public class UserSecrets
{
    public string AzureAIKey { get; private set; }
    public string OpenAIEndpoint { get; private set; }
    public string OpenAIDeployment { get; private set; }
    public string OpenAIImageDeployment { get; private set; }
    public string TranslatorEndpoint { get; private set; }
    public string TranslatorRegion { get; private set; }
    public string VisionEndpoint { get; private set; }
    public string SpeachRegion { get; private set; }
    public string DocumentIntelligenceEndpoint { get; private set; }
    
    public UserSecrets()
    {
        var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();

        this.AzureAIKey = config["azureAIKey"];
        this.OpenAIEndpoint = config["openAIEndpoint"];
        this.OpenAIDeployment = config["openAIDeployment"];
        this.OpenAIImageDeployment = config["openAIImageDeployment"];
        this.TranslatorEndpoint = config["translatorEndpoint"];
        this.TranslatorRegion = config["translatorRegion"];
        this.VisionEndpoint = config["visionEndpoint"];
        this.SpeachRegion = config["speachRegion"];
        this.DocumentIntelligenceEndpoint = config["documentIntelligenceEndpoint"];
    }
}