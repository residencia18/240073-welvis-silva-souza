FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
COPY . .
WORKDIR /src

RUN dotnet publish "AtividadeSala1.csproj" -c Release -o /app/ \
    --runtime linux-musl-x64 \
    --self-contained true \
    /p:PublishTrimmed=true \
    /p:PublishSingleFile=true 

FROM mcr.microsoft.com/dotnet/runtime-deps:8.0-preview-alpine AS runtime

EXPOSE 8080

RUN adduser --disabled-password \
  --home /app \
  --gecos '' dotnetuser && chown -R dotnetuser /app

USER dotnetuser

WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["./AtividadeSala1"]

