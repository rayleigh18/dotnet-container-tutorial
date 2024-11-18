# .NET Weather Forecast API

A simple REST API built with .NET that provides weather forecast data.

## Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/products/docker-desktop) (optional)

## Getting Started

### Local Development

1. Clone the repository:
   ```bash
   git clone https://github.com/rayleigh18/dotnet-container-tutorial.git
   cd dotnet-container-tutorial
   ```
2. Build and run the application:
   ```bash
   dotnet build
   dotnet run
   ```

3. Access the API:
   - Swagger UI: http://localhost:8080/swagger
   - API Endpoint: http://localhost:8080/weatherforecast

### Docker Deployment

1. Build the Docker image:
   ```bash
   docker build -t weatherforecast-api .
   ```

2. Run the container:
   ```bash
   docker run -p 8080:8080 weatherforecast-api
   ```

3. Access the containerized API:
   - Swagger UI: http://localhost:8080/swagger
   - API Endpoint: http://localhost:8080/weatherforecast

## API Endpoints

### GET /weatherforecast
Returns a 5-day weather forecast with random temperatures and conditions.

Response format:
```json
[
  { "date": "2024-01-01", "temperatureC": 30, "summary": "Sunny" },
  ...
]
```

### GET /swagger
Access the Swagger UI for API documentation and testing.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
