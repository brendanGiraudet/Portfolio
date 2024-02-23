FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
ARG BUILDPLATFORM
WORKDIR /app
EXPOSE 8080

FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILDPLATFORM
WORKDIR /src
COPY . .
RUN dotnet restore "./Portfolio.App.csproj" 

RUN dotnet build "./Portfolio.App.csproj" -c Release -o /app/build

FROM build AS publish
WORKDIR /src
RUN dotnet publish "./Portfolio.App.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Portfolio.App.dll"]