# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:5.0

# ENV PATH="${PATH}:~/.dotnet/tools"
# RUN ["dotnet", "tool", "install", "--global", "dotnet-ef"]

COPY . /app
WORKDIR /app

RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]

EXPOSE 80

# RUN chmod +x ./entrypoint.sh
# CMD /bin/bash ./entrypoint.sh

CMD ["dotnet", "watch", "run", "--project", "./login-example-SRA", "--server.urls", "http://*:80"]