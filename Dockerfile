# --- Стадия сборки (build) ---
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Копируем .csproj и восстанавливаем зависимости (ускоряет кэширование)
COPY *.csproj ./
RUN dotnet restore

# Копируем всё остальное и публикуем
COPY . .
RUN dotnet publish -c Release -o /app/publish

# --- Стадия выполнения (runtime) ---
# --- Стадия выполнения (runtime) ---
FROM mcr.microsoft.com/dotnet/aspnet:9.0-alpine
WORKDIR /app
COPY --from=build /app/publish ./
EXPOSE 80
ENTRYPOINT ["dotnet", "lab10.dll"]
# Копируем только опубликованные файлы
COPY --from=build /app/publish ./

# Пробрасываем порт и запускаем
EXPOSE 80
ENTRYPOINT ["dotnet", "lab10.dll"]
