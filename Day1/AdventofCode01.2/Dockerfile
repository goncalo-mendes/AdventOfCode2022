FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AdventofCode01.2/AdventofCode01.2.csproj", "AdventofCode01.2/"]
RUN dotnet restore "AdventofCode01.2/AdventofCode01.2.csproj"
COPY . .
WORKDIR "/src/AdventofCode01.2"
RUN dotnet build "AdventofCode01.2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AdventofCode01.2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AdventofCode01.2.dll"]
