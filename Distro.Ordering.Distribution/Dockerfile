#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Distro.Ordering.Distribution/Distro.Ordering.Distribution.csproj", "Distro.Ordering.Distribution/"]
COPY ["Distro.Ordering.DataAccess/Distro.Ordering.DataAccess.csproj", "Distro.Ordering.DataAccess/"]
COPY ["Distro.Seedworks.Infrastructure/Distro.Seedworks.Infrastructure/Distro.Seedworks.Infrastructure.csproj", "Distro.Seedworks.Infrastructure/Distro.Seedworks.Infrastructure/"]
COPY ["Distro.Domain.Common/Distro.Domain.Common/Distro.Domain.Common.csproj", "Distro.Domain.Common/Distro.Domain.Common/"]
COPY ["Distro.Ordering.Domain/Distro.Ordering.Domain.csproj", "Distro.Ordering.Domain/"]
COPY ["Distro.Ordering.Application.Services/Distro.Ordering.Application.Services.csproj", "Distro.Ordering.Application.Services/"]
RUN dotnet restore "Distro.Ordering.Distribution/Distro.Ordering.Distribution.csproj"
COPY . .
WORKDIR "/src/Distro.Ordering.Distribution"
RUN dotnet build "Distro.Ordering.Distribution.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Distro.Ordering.Distribution.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Distro.Ordering.Distribution.dll"]
