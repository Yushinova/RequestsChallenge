using RequestsChallenge.Api;
using RequestsChallenge.Model;
using RequestsChallenge.Storage;

var builder = WebApplication.CreateBuilder(args);

// добавление сервисов в IoC-контейнер
builder.Services.AddControllers();
builder.Services.AddTransient<RequestService>();
builder.Services.AddTransient<IRequestRepository, RequestStorage>();
builder.Services.AddDbContext<ApplicationDbContext>();

var app = builder.Build();
app.UseMiddleware<ErrorMiddleware>();
app.UseMiddleware<RequestMiddleware>();

app.MapControllers();

app.Run();


// ЗАДАНИЕ:
// 1. Скачать, распаковать, открыть проект
// 2. Поправить строку подключения на свою, применить миграции (Update-Database)
// 3. Запустить и протестировать методы API
// 4. Реализовать middleware через app.Use в Program.cs,
//      в котором записывать в БД информацию о полученном запросе
//      подумать над сбпособами внедрения зависимости RequestService в данный middleware
