using NotToday;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddNotToday();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseNotToday();

app.MapGet("/slow-operation", async (CancellationToken ct) =>
{
    await Task.Delay(50, ct);
    return Results.Ok();
});

app.Run();