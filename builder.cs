using Microsoft.SemanticKernel;

// Create kernel
var builder = Kernel.CreateBuilder();
builder.AddAzureOpenAIChatCompletion(
    deploymentName: "[The name of your deployment]",
    endpoint: "[Your Azure endpoint]",
    apiKey: "[Your Azure OpenAI API key]",
    modelId: "[The name of the model]" // optional
);
var kernel = builder.Build();