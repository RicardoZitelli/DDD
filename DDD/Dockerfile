#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["DDD/DDD.Services.csproj", "DDD/"]
COPY ["DDD.Infraestrutura/DDD.Infrastructure.csproj", "DDD.Infraestrutura/"]
COPY ["DDD.Dominio/DDD.Domain.csproj", "DDD.Dominio/"]
COPY ["DDD.Services/DDD.Application.csproj", "DDD.Services/"]
RUN dotnet restore "DDD/DDD.Services.csproj"
COPY . .
WORKDIR "/src/DDD"
RUN dotnet build "DDD.Services.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DDD.Services.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DDD.Services.dll"]