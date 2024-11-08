# Knowit Azure AI Julkalender 🎅🏻
Ett repository för Knowits Azure AI Julkalender. Här samlas alla kodexempel från Knowits Julkalender med fokus på Azure AI services.

## Kalendern 🎄
1. TODO: Introduktion till **Azure AI Services**, **Model browsing**, **Benchmarking** och **Deployments** i Azure AI Studio
3. Chat Bot med **[Azure Open AI](https://github.com/Adolfi/AzureAIXmasCalendar/blob/main/Clients/OpenAIClient.cs#L11)**
4. Översättningar med **[Azure AI Translator](https://github.com/Adolfi/AzureAIXmasCalendar/blob/main/Clients/TranslatorClient.cs#L7)**
5. Bildanalysering med **[Azure AI Vision](https://github.com/Adolfi/AzureAIXmasCalendar/blob/main/Clients/VisionClient.cs#L8)**
6. Bildgenerering med **[Azure OpenAI Dall-E](https://github.com/Adolfi/AzureAIXmasCalendar/blob/main/Clients/OpenAIClient.cs#L18)**
7. Speach Synthesis med **[Azure AI Speach](https://github.com/Adolfi/AzureAIXmasCalendar/blob/main/Clients/SpeachClient.cs#L9)**
8. Fil analysering med **[Azure AI Document Intelligence](https://github.com/Adolfi/AzureAIXmasCalendar/blob/main/Clients/DocumentIntelligenceClient.cs#L6)**
9. Textsummering med **[Azure AI Language](https://github.com/Adolfi/AzureAIXmasCalendar/blob/main/Clients/LanguageClient.cs#L8)**
10. Hur fungerar **[Content Safety Filters](https://github.com/Adolfi/AzureAIXmasCalendar/blob/main/Program.cs#L26)** och vad är **Responsible AI**?

## Setup user secrets 
För att komma igång med koden så behövs user-secrets sättas upp mot dina egna nycklar, dessa nycklar får man första dagen på kalendern när Azure AI Services skapas upp.

```
dotnet user-secrets init
dotnet user-secrets set azureAIKey <your-azure-ai-key>
dotnet user-secrets set openAIEndpoint <your-azure-open-ai-endpoint>
dotnet user-secrets set openAIDeployment <your-azure-open-ai-deployment-name>
dotnet user-secrets set openAIImageDeployment <your-azure-open-ai-image-deployment-name>
dotnet user-secrets set translatorEndpoint <your-azure-ai-translator-endpoint>
dotnet user-secrets set translatorRegion <your-azure-ai-translator-region>
dotnet user-secrets set visionEndpoint <your-azure-ai-vision-endpoint>
dotnet user-secrets set speachEndpoint <your-azure-ai-speach-endpoint> 
dotnet user-secrets set speachRegion <your-azure-ai-speach-region>
dotnet user-secrets set documentIntelligenceEndpoint <your-azure-ai-document-intelligence-endpoint>
dotnet user-secrets set languageEndpoint <your-azure-ai-language-endpoint>
dotnet user-secrets list
```
