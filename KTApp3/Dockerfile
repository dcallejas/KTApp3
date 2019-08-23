#step 1: build 
FROM microsoft/dotnet:sdk AS build-stage 
RUN mkdir app 
WORKDIR /app

COPY *.csproj . 
RUN dotnet restore 
COPY . .

#publicamos a la carpeta out
RUN dotnet publish -c Release -o out

#step 2: run 
FROM microsoft/dotnet:aspnetcore-runtime 
WORKDIR /app 
COPY --from=build-stage /app/out . 
ENTRYPOINT dotnet KTApp3.dll --urls "http://0.0.0.0:5000"