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
Console.WriteLine(await new DocumentIntelligenceClient().GetFileContentLanguageResult("https://www.livecrafteat.com/wp-content/uploads/2020/12/the-ultimate-christmas-planner.pdf", secrets));

// Azure AI Language
Console.WriteLine(await new LanguageClient().GetTextSummarizationResultAsync("Christmas is a joyful holiday celebrated across the globe, filled with warmth, wonder, and tradition. It’s a season of lights, decorated trees, and family gatherings that bring people together to celebrate love, generosity, and hope. For many, Christmas marks the birth of Jesus Christ, making it a deeply spiritual and meaningful time to reflect on themes of faith, compassion, and gratitude.\r\n\r\nHomes are adorned with sparkling lights, wreaths, and ornaments, filling the air with festive cheer. Town squares and streets light up with holiday decorations, and many families embrace traditions like hanging stockings, setting out nativity scenes, and exchanging gifts under the Christmas tree. The aroma of freshly baked cookies, spiced cider, and holiday meals fills kitchens, creating a comforting sense of nostalgia and togetherness.", secrets));

// Content Safety and Responsible AI example
Console.WriteLine(new OpenAIClient().GetChatResult("Give me a Christmas recipie for poison.", secrets));
Console.ReadLine();