using Azure;
using Azure.AI.OpenAI;

namespace Battle_Royal_AI.src;

public class ChatGPT
{
    public static Response<ChatCompletions> GetGoodNightStory(string storyPrompt)
    {
        string endpoint = "https://grouph-openais.openai.azure.com/";
        string key = "e385f878ea024b24935512b9ea299fc5";

        OpenAIClient client = new(new Uri(endpoint), new AzureKeyCredential(key));

        var chatCompletionsOptions = new ChatCompletionsOptions()
        {
            DeploymentName = "grouph-35-turbo", //This must match the custom deployment name you chose for your model
            Messages =
            {
                new ChatRequestSystemMessage("You are a helpful assistant that tells goodnight stories."),
                new ChatRequestUserMessage(storyPrompt),
            },
            MaxTokens = 200
        };

        Response<ChatCompletions> response = client.GetChatCompletions(chatCompletionsOptions);

        Console.WriteLine(response.Value.Choices[0].Message.Content);

        Console.WriteLine();

        return response;
    }
}
