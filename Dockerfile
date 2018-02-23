FROM microsoft/aspnetcore-build AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build AS build
WORKDIR /src
COPY *.sln ./
COPY Pokedex.Webapi/Pokedex.Webapi.csproj Pokedex.Webapi/
COPY Pokedex.Repositories/Pokedex.Repositories.csproj Pokedex.Repositories/
COPY Pokedex.Facades/Pokedex.Facades.csproj Pokedex.Facades/
RUN dotnet restore
COPY . .
WORKDIR /src/Pokedex.Webapi
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Pokedex.Webapi.dll"]