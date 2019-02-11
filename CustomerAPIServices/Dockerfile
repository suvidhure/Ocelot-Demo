FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY CustomerAPIServices/CustomerAPIServices.csproj CustomerAPIServices/
RUN dotnet restore CustomerAPIServices/CustomerAPIServices.csproj
COPY . .
WORKDIR /src/CustomerAPIServices
RUN dotnet build CustomerAPIServices.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish CustomerAPIServices.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CustomerAPIServices.dll"]
