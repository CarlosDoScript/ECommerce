using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.S3;
using Amazon.SQS;
using API.ECommerceLambda.Repositories;
using API.ECommerceLambda.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddAWSLambdaHosting(LambdaEventSource.RestApi);

builder.Services.AddScoped<IAmazonDynamoDB, AmazonDynamoDBClient>();
builder.Services.AddScoped<IDynamoDBContext, DynamoDBContext>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

builder.Services.AddScoped<IAmazonSQS, AmazonSQSClient>();
builder.Services.AddScoped<IAmazonS3, AmazonS3Client>();
builder.Services.AddScoped<IPedidoService, PedidoService>();
builder.Services.AddScoped<IPedidoService, PedidoService>();

var app = builder.Build();


app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.MapGet("/", () => "Welcome to running ASP.NET Core Minimal API on AWS Lambda");

app.Run();
