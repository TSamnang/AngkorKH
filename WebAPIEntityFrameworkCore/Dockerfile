# Use the .NET SDK image for building
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app

# Copy the csproj file and restore dependencies
COPY WebAPIEntityFrameworkCore.csproj ./
RUN dotnet restore

# Copy the rest of the files
COPY . ./

# Build and publish the app
RUN dotnet publish -c Release -o /out

# Use the .NET runtime image for the final build
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

WORKDIR /app
COPY --from=build /out .

ENTRYPOINT ["dotnet", "WebAPIEntityFrameworkCore.dll"]
