# AzureAIXmasCalendar
Ett repository för Knowits Azure AI Julkalender.

## Calendar
1. Introduktion till Azure AI Services och Azure AI Studio
2. Model catalog, benchmarking and deployment i Azure AI Studio
3. Skapa en Chat Bot med Azure Open AI
4. Översättningar med Azure AI Translator
5. Bildanalysering med Azure AI Vision
6. Bildgenerering med Azure OpenAI Dall-E
7. Speach Synthesis med Azure AI Speach
8. TODO: Fil analysering med Azure AI Document Intelligence
9. Vad är Content Safety och Responsible AI?

## Setup user secrets
För att komma igång med koden så behövs user-secrets sättas upp mot dina egna nycklar, dessa får i första dagen på kalendern när Azure AI Services skapas upp.

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
dotnet user-secrets list
