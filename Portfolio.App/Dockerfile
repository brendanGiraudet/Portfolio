FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILDPLATFORM
ARG TARGETPLATFORM
ARG RID=linux-arm
RUN if [ "$TARGETPLATFORM" == "linux/amd64" ]; then \
    RID=linux-x64 ; \
    elif [ "$TARGETPLATFORM" == "linux/arm/v7" ]; then \
    RID=linux-arm ; \
    elif [ "$TARGETPLATFORM" == "linux/arm64" ]; then \
    RID=linux-arm64 ; \
    fi

WORKDIR /src
COPY . .
RUN dotnet restore "./Portfolio.App.csproj" -r $RID

RUN dotnet build "./Portfolio.App.csproj" -c Release -o /app/build -r $RID --self-contained false

FROM build AS publish
WORKDIR /src
RUN dotnet publish "./Portfolio.App.csproj" -c Release -o /app/publish -r $RID --self-contained false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Portfolio.App.dll"]