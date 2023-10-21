#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.
# cd to HDC.Monolith dir
# docker build . -t hdc.monolith
# docker run -d -p 50010:80 --name hdc.monolith hdc.monolith

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["HDC.Monolith.csproj", "HDC.Monolith/"]
RUN dotnet restore "HDC.Monolith/HDC.Monolith.csproj"
WORKDIR "/src/HDC.Monolith"
COPY . .
RUN dotnet build "HDC.Monolith.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HDC.Monolith.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HDC.Monolith.dll"]