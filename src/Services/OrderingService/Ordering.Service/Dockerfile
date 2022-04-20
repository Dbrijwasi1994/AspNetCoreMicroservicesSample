#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Services/OrderingService/Ordering.Service/Ordering.Service.csproj", "Services/OrderingService/Ordering.Service/"]
COPY ["Services/OrderingService/Ordering.Application/Ordering.Application.csproj", "Services/OrderingService/Ordering.Application/"]
COPY ["Services/OrderingService/Ordering.Domain/Ordering.Domain.csproj", "Services/OrderingService/Ordering.Domain/"]
COPY ["Services/OrderingService/Ordering.Infrastructure/Ordering.Infrastructure.csproj", "Services/OrderingService/Ordering.Infrastructure/"]
RUN dotnet restore "Services/OrderingService/Ordering.Service/Ordering.Service.csproj"
COPY . .
WORKDIR "/src/Services/OrderingService/Ordering.Service"
RUN dotnet build "Ordering.Service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ordering.Service.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ordering.Service.dll"]
