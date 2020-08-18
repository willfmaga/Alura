#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Aulas/Aula1/CasaDoCodigo/CasaDoCodigo.csproj", "Aulas/Aula1/CasaDoCodigo/"]
RUN dotnet restore "Aulas/Aula1/CasaDoCodigo/CasaDoCodigo.csproj"
COPY . .
WORKDIR "/src/Aulas/Aula1/CasaDoCodigo"
RUN dotnet build "CasaDoCodigo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CasaDoCodigo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CasaDoCodigo.dll"]