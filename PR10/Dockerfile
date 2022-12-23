FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["PR10/PR10.csproj", "PR10/"]
RUN dotnet restore "PR10/PR10.csproj"
COPY . .
WORKDIR "/src/PR10"
RUN dotnet build "PR10.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PR10.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PR10.dll"]
