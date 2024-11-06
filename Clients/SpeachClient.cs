using Azure;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using System;
namespace Clients;

public class SpeachClient
{
    public async Task<string> SpeakAsync(string message, UserSecrets secrets)
    {
        var config = SpeechConfig.FromSubscription(secrets.AzureAIKey, secrets.SpeachRegion);
        using var synthesizer = new SpeechSynthesizer(config);
        var result = await synthesizer.SpeakTextAsync(message);

        return result.Reason == ResultReason.SynthesizingAudioCompleted ? "Speech synthesized to speaker for text [" + message + "]" : "Speech synthesized failed.";
    }
}