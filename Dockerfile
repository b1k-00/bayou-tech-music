# Docker multi-stage setup is a best practice. See https://docs.docker.com/develop/develop-images/multistage-build/

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS source
WORKDIR /app
COPY . ./

# Get Base Image (Full .NET Core SDK)
FROM source AS build
RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM source AS test
WORKDIR /app
RUN dotnet test

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
EXPOSE 80

FROM runtime as deploy
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "JuniorAssociate.dll"]