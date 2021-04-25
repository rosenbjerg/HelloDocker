FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine as builder
WORKDIR /app/src
COPY ./HelloDocker.sln ./HelloDocker.sln
COPY ./HelloDocker/HelloDocker.csproj ./HelloDocker/HelloDocker.csproj
RUN dotnet restore -r linux-musl-x64 ./HelloDocker.sln
COPY ./HelloDocker/* ./HelloDocker/
RUN dotnet publish -r linux-musl-x64 -c Release --no-restore /p:PublishTrimmed=true -o /app/build ./HelloDocker/HelloDocker.csproj

RUN addgroup -S appgroup && adduser -S appuser -G appgroup
USER appuser

CMD /app/build/HelloDocker

