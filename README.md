# inventory-demo

## Pre-requisites
Install .NET Core (https://www.microsoft.com/net/core/platform)
Install Docker

## To Run
1. dotnet restore
2. Two ways
    - mssql > CREATE DATABASE inventory (MAC)  
    - or sqllocaldb.exe c inventory (WINDOWS)
3. dotnet ef database update
4. dotnet run

## To view the API endpoints
http://localhost:5000/swagger/ui
