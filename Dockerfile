#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["entrevista.csproj", "."]
RUN dotnet restore "./entrevista.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "entrevista.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "entrevista.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
# Padr�o de container ASP.NET
# ENTRYPOINT ["dotnet", "entrevista.dll"]
# Op��o utilizada pelo Heroku
CMD ASPNETCORE_URLS=http://*:$PORT dotnet entrevista.dll