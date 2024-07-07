# Use the official .NET 8.0 SDK image for building the project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the project file and restore dependencies
COPY ["/src/Mango_Services.Coupon.API.csproj", "MangoAPI/"]
RUN dotnet restore "MangoAPI/Mango_Services.Coupon.API.csproj"

# Copy the remaining files and build the project
COPY . .
WORKDIR "/src/"
RUN dotnet build "src/Mango_Services.Coupon.API.csproj" -c Release -o /app/build

# Publish the project
FROM build AS publish
RUN dotnet publish "src/Mango_Services.Coupon.API.csproj" -c Release -o /app/publish

# Use the official .NET 8.0 runtime image for running the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Specify the entry point for the application
ENTRYPOINT ["dotnet", "Mango_Services.Coupon.API.dll"]
