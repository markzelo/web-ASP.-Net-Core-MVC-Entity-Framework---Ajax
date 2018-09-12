#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/aspnetcore:2.0-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-1709 AS build
WORKDIR /src
COPY ["aspnet_core/aspnet_core.csproj", "aspnet_core/"]
RUN dotnet restore "aspnet_core/aspnet_core.csproj"
COPY . .
WORKDIR "/src/aspnet_core"
RUN dotnet build "aspnet_core.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "aspnet_core.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "aspnet_core.dll"]