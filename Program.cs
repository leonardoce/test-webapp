using Npgsql;

var connString = Environment.GetEnvironmentVariable("DSN");
if (connString == null) {
    const String DEFAULT_DSN = "Host=/tmp;Database=postgres";
    System.Console.WriteLine("WARNING: Using default DSN");
    connString = DEFAULT_DSN;
}

var dataSource = NpgsqlDataSource.Create(connString);

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/test", () => {
    using (var cmd = dataSource.CreateCommand("SELECT 1")) {
        cmd.ExecuteScalar();
    }
    return "Ciao";
});

app.Run();
