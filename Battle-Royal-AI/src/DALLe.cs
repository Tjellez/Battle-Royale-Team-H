using Azure.AI.OpenAI;
using Azure;

namespace Battle_Royal_AI.src;

public class DALLe
{
    public static async Task<Uri> GetDALLeImage(string prompt)
    {
        string endpoint = "https://oai-test-swedencentral3.openai.azure.com/";
        string key = "947646d98ae84a3bae04a5f0195bc38d";

        OpenAIClient client = new(new Uri(endpoint), new AzureKeyCredential(key));

        Response<ImageGenerations> imageGenerations = await client.GetImageGenerationsAsync(
            new ImageGenerationOptions()
            {
                Prompt = prompt,
                Size = ImageSize.Size1024x1024,
                DeploymentName = "Dalle3"
            });

        // Image Generations responses provide URLs you can use to retrieve requested images
        return imageGenerations.Value.Data[0].Url;
    }
}
