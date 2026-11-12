FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY global.json LaQuiebraWeb.slnx ./
COPY LaQuiebraModelo/LaQuiebraModelo.csproj LaQuiebraModelo/
COPY LaQuiebraBack/LaQuiebraBack.csproj LaQuiebraBack/
COPY LaQuiebraFront/LaQuiebraFront.csproj LaQuiebraFront/
RUN dotnet restore LaQuiebraWeb.slnx

COPY . .
RUN dotnet publish LaQuiebraFront/LaQuiebraFront.csproj \
    --configuration $BUILD_CONFIGURATION \
    --no-restore \
    --output /app/front
RUN dotnet publish LaQuiebraBack/LaQuiebraBack.csproj \
    --configuration $BUILD_CONFIGURATION \
    --no-restore \
    --output /app/publish \
    /p:UseAppHost=false \
    && mkdir -p /app/publish/wwwroot \
    && cp -a /app/front/wwwroot/. /app/publish/wwwroot/

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
ENV ASPNETCORE_HTTP_PORTS=8080
EXPOSE 8080

COPY --from=build /app/publish .
USER $APP_UID
ENTRYPOINT ["dotnet", "LaQuiebraBack.dll"]
