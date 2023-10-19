dotnet new gitignore

git init
git add *
git commit -m 'iniciando'

dotnet new sln -o ProjetoSupermercado
dotnet new webapi -o Supermercado.Api

dotnet sln .\Supermercado.sln add .\Supermercado.Api\Supermercado.Api.csproj
