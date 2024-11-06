using Clients;
UserSecrets secrets = new UserSecrets();

// Azure OpenAI Chat
Console.WriteLine(new OpenAIClient().GetChatResult("What is Christmas?", secrets));

// Azure AI Translator
Console.WriteLine(await new TranslatorClient().GetTranslateResult("I wanna wish you a Merry Christmas, from the best of my heart!", "en", "sv", secrets));

// Azure AI Vision
Console.WriteLine(new VisionClient().GetImageCaptionResult("https://img.freepik.com/premium-vector/hand-drawn-cute-santa-claus-logo-santa-cartoon-logo-santa-logo-santa-clipart-ai-generated_1088958-9.jpg", secrets));

// Azure AI OpenAI Image Generation with Dall-E
Console.WriteLine(await new OpenAIClient().GenerateImageAsync("A Christmas Tree", secrets));

// Azure AI Speach
Console.WriteLine(await new SpeachClient().SpeakAsync("Merry Christmas everyone!", secrets));

// Azure Document Intelligence
Console.WriteLine(new DocumentIntelligenceClient().GetFileContentLanguageResult("TODO: PATH", secrets));