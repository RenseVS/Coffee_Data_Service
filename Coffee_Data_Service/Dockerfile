#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Coffee_Data_Service/Coffee_Data_Service.csproj", "Coffee_Data_Service/"]
RUN dotnet restore "Coffee_Data_Service/Coffee_Data_Service.csproj"
COPY . .
WORKDIR "/src/Coffee_Data_Service"
RUN dotnet build "Coffee_Data_Service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Coffee_Data_Service.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Coffee_Data_Service.dll"]
