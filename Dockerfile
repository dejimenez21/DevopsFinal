FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

COPY ./DevopsPractice/*.csproj ./
RUN dotnet restore

COPY ./DevopsPractice/. ./
RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
EXPOSE 80
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet", "DevopsPractice.dll" ]


# FROM mcr.microsoft.com/dotnet/aspnet:5.0
# WORKDIR /app
# EXPOSE 80
# COPY --from=build-env /app .
# RUN dotnet run

