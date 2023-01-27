dotnet new webapi
dotnet watch run

dotnet tool install --global dotnet-ef


dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet add package Microsoft.EntityFrameworkCore.SqlServer
usamos o SqlServer nesse projeto, coloque outro sufixo para outro tipo de banco de dados

colocar as variaveis de conexão nos .json e no Program.cs

dotnet-ef migrations add CriacaoTabelaContato

dotnet-ef database update