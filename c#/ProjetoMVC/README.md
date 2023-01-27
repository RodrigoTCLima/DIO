Correspondentemente as controllers, existem pastas na pasta Views, e correspondente aos métodos nas controllers, haverão arquivos .cshtml correspondentes.

dotnet new mvc

 dotnet watch run
  dotnet add package Microsoft.EntityFrameworkCore.SqlServer
   dotnet add package Microsoft.EntityFrameworkCore.Design   
   dotnet ef migrations add AdicionaTabelaContatos
    dotnet ef database update