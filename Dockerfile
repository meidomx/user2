﻿FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["user2.csproj", "./"]
RUN dotnet restore "user2.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "user2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "user2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "user2.dll"]
