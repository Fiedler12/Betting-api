FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /App

EXPOSE 8080

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore "BettingApi.csproj"
# Build and publish a release
RUN dotnet build "BettingApi.csproj" -o app/build

RUN dotnet publish -c Release -o /app/publish 

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY --from=build-env /app/publish .
ENTRYPOINT ["dotnet", "BettingApi.dll"]