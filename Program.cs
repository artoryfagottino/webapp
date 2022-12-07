var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();


// MVC
// 
// MODEL - тут хранятся данные,к ним обращается  CONTROLLER
// VIEW - То с чем взаимодействует пользователь(браузер,страничка)
// CONTROLLER - принимает действия пользователя и обрабатывает их,и запрашивает данные 
// у MODEL 