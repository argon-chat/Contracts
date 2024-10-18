using Argon.Grains.Interfaces;
using Microsoft.Extensions.Logging;

namespace Argon.Grains;

public class Hello(ILogger<Hello> logger) : Grain, IHello
{
    [ResponseTimeout("00:00:10")]
    public Task<string> DoIt(string who)
    {
        var message = $"Hello, {who}!";
        logger.LogInformation(message);
        return Task.FromResult(message);
    }
}