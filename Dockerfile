# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy csproj and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o /app

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app ./

# Configure the container to listen on port 5000
ENV ASPNETCORE_URLS=http://+:5000

# Expose port 5000
EXPOSE 5000

ENTRYPOINT ["dotnet", "dotnet-container-tutorial.dll"] 