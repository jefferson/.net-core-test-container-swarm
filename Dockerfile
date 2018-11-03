FROM microsoft/dotnet:sdk AS build-env

WORKDIR /app

# Copy csproj and restore as distinct layers
COPY /exercicio-3/*.csproj ./

RUN dotnet restore

# Copy everything else and build
COPY /exercicio-3/ ./

RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/dotnet:aspnetcore-runtime

WORKDIR /app

COPY --from=build-env /app/out .

ENTRYPOINT ["dotnet", "exercicio-3.dll"]