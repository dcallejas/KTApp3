FROM microsoft/dotnet:sdk
RUN mkdir app
WORKDIR /app
COPY . .
RUN dotnet restore
CMD dotnet watch run "http://0.0.0.0:4000;https://0.0.0.0:4001"