FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine as builder
WORKDIR /app/src
COPY ./HelloDocker.sln ./HelloDocker.sln
COPY ./HelloDocker/HelloDocker.csproj ./HelloDocker/HelloDocker.csproj
RUN dotnet restore -r linux-musl-x64 ./HelloDocker.sln
COPY ./HelloDocker/* ./HelloDocker/
RUN dotnet publish -r linux-musl-x64 -c Release --no-restore /p:PublishTrimmed=true -o /app/build ./HelloDocker/HelloDocker.csproj



FROM amd64/alpine as runtime
RUN apk add --update --no-cache icu-libs

RUN addgroup -S appgroup && adduser -S appuser -G appgroup
USER appuser

COPY --from=builder /app/build /app
CMD /app/HelloDocker