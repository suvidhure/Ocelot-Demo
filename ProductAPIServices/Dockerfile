FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ProductAPIServices/ProductAPIServices.csproj ProductAPIServices/
RUN dotnet restore ProductAPIServices/ProductAPIServices.csproj
COPY . .
WORKDIR /src/ProductAPIServices
RUN dotnet build ProductAPIServices.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ProductAPIServices.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ProductAPIServices.dll"]
