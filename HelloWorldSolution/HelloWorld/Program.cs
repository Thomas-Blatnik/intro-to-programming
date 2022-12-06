using HelloWorld;

var builder = WebApplication.CreateBuilder(args);

// do some configuration of the servies (none for this one now)
builder.Services.AddSingleton<DateUtils>();
var app = builder.Build();

app.MapGet("/break/{minutes:int}", (int minutes, DateUtils utils) =>
{
    var response = new BreakTimerResponse(
        minutes,
        DateTime.Now,
        utils.TakeABreak(minutes)
        );
    return Results.Ok(response);
});

app.Run(); // "Blocking"

public record BreakTimerResponse(int Minutes, DateTime StartTime, DateTime EndTime);