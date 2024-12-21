using RequestsChallenge.Api;
using RequestsChallenge.Model;
using RequestsChallenge.Storage;

var builder = WebApplication.CreateBuilder(args);

// ���������� �������� � IoC-���������
builder.Services.AddControllers();
builder.Services.AddTransient<RequestService>();
builder.Services.AddTransient<IRequestRepository, RequestStorage>();
builder.Services.AddDbContext<ApplicationDbContext>();

var app = builder.Build();
app.UseMiddleware<ErrorMiddleware>();
app.UseMiddleware<RequestMiddleware>();

app.MapControllers();

app.Run();


// �������:
// 1. �������, �����������, ������� ������
// 2. ��������� ������ ����������� �� ����, ��������� �������� (Update-Database)
// 3. ��������� � �������������� ������ API
// 4. ����������� middleware ����� app.Use � Program.cs,
//      � ������� ���������� � �� ���������� � ���������� �������
//      �������� ��� ���������� ��������� ����������� RequestService � ������ middleware
