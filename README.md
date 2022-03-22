# Simple .NET6 Web API Microservice on Containers

This simple microservice lists random courses in JSON format.

# Build the image

Build the container image.

    docker build -t gulangurman/dotnet6-microservice:1.0 .

# Run

Run the container. Map to port 3000.

    docker run -p 3000:80 --name dotnet-service-container gulangurman/dotnet6-microservice:1.0

# View results

Browse http://localhost:3000/Course to view JSON output.