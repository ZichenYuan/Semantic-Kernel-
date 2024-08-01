using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Plugins.Core;

var builder = Kernel.CreateBuilder();
builder.AddAzureOpenAIChatCompletion(
    "test",
    "https://sunnyyuan.openai.azure.com/",
    "679c07db09e04eb887e19980a96beea7",
    "gpt-35-turbo-16k");
builder.Plugins.AddFromType<TimePlugin>();

var kernel = builder.Build();

var result = await kernel.InvokePromptAsync(
        "Give me a list of breakfast foods with eggs and cheese");
Console.WriteLine(result);

var currentDay = await kernel.InvokeAsync("TimePlugin", "DayOfWeek");
Console.WriteLine(currentDay);