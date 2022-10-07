#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Sistemarcas.Api/Sistemarcas.Presentation.csproj", "Sistemarcas.Api/"]
COPY ["Sistemarcas.Infrastructure/Sistemarcas.Infrastructure.csproj", "Sistemarcas.Infrastructure/"]
COPY ["Sistemarcas.Business/Sistemarcas.Domain.csproj", "Sistemarcas.Business/"]
RUN dotnet restore "Sistemarcas.Api/Sistemarcas.Presentation.csproj"
COPY . .
WORKDIR "/src/Sistemarcas.Api"
RUN dotnet build "Sistemarcas.Presentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Sistemarcas.Presentation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Sistemarcas.Presentation.dll"]