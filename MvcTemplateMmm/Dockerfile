#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MvcTemplateMmm/MvcTemplateMmm.csproj", "MvcTemplateMmm/"]
COPY ["Template.Models/Template.Models.csproj", "Template.Models/"]
COPY ["Template.Services/Template.Services.csproj", "Template.Services/"]
COPY ["Template.Data/Template.Data.csproj", "Template.Data/"]

RUN dotnet restore "MvcTemplateMmm/MvcTemplateMmm.csproj"
COPY . .
WORKDIR "/src/MvcTemplateMmm"
RUN dotnet build "MvcTemplateMmm.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MvcTemplateMmm.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MvcTemplateMmm.dll"]