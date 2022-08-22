FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Task 4/Task 4.csproj", "Task 4/"]
RUN dotnet restore "Task 4/Task 4.csproj"
COPY . .
WORKDIR "/src/Task 4"
RUN dotnet build "Task 4.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task 4.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task 4.dll"]
