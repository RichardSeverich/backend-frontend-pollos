# Csharp
# Sales App

This is an application that helps to manage sales

# Prerequisites 🔨

1. Install Windows 10, Linux or Mac
2. Install .Net Core version 5.0.202
```
https://dotnet.microsoft.com/download
```

# Installation 🔧

### Installation SQL Server in docker.

0. Docker 20.10.5

1. download docker Sql Server image: 

```
docker pull mcr.microsoft.com/mssql server:2019-CU9-ubuntu-16.04
```

2. start container:

```
docker run -d --name sqlserver -e SA_PASSWORD=Secret-123 -e ACCEPT_EULA=Y -p 1433:1433  mcr.microsoft.com/mssql/server:2019-CU9-ubuntu-16.04
```
3. Sql Credentials

```
host: localhost
user: sa
password: Secret-123
port: 1433
database/schema: master
```

# Deploy 🚀

### Deploy Docker

0. execute all queries from sql folder: ```Infrastructure\PollosDatabase\Sql```

1. configure .env: ```Infrastructure\PollosAPIREST\.env```

2. execute ```Infrastructure\PollosAPIREST\dotnet build```

3. execute ```Infrastructure\PollosAPIREST\dotnet run```

# Diagrams 🎨

## Class Diagram

## Data Base

## Architecture

## Descriptive Architecture

# Usage 🎮

# Swagger Example

```
https://localhost:5001/swagger/index.html
```

## API:

#### Login:

```
POST localhost:5001/login

{
  "username": "micky",
  "password": "secret123"
  "token": "Bearer ..."
}
```

#### Users:

```
GET localhost:5001/user
POST localhost:5001/user
PUT localhost:5001/user/1
DELETE localhost:5001/user/1

{
  "dni": "6405889",
  "name": "Rodrigo",
  "lastname": "Paredes Aguilar",
  "birthDate": "10/10/1995 00:00:00",
  "address": "Av. B.Galindo Km 2",
  "phoneNumber": "77859462",
  "email": "rodri@gmail.com",
  "username": "rodri_agui",
  "password": "fcf730b6d95236ecd3c9fc2d92d7b6b2bb061514961aec041d6c7a7192f592e4",
  "id": 2,
  "createdBy": "micky",
  "updatedBy": null,
  "creationDate": "06/30/2021 15:39:10",
  "updateDate": null
}
```

#### Clients:

```
GET localhost:5001/client
POST localhost:5001/client
PUT localhost:5001/client/1
DELETE localhost:5001/client/1

{
  "dni": "984521",
  "name": "Edgar Barriga",
  "id": 1,
  "createdBy": "micky",
  "updatedBy": null,
  "creationDate": "06/30/2021 15:41:02",
  "updateDate": null
}
```

#### Products:

```
GET localhost:5001/product
POST localhost:5001/product
PUT localhost:5001/product/1
DELETE localhost:5001/product/1

{
  "productName": "Economic chicken",
  "productPrice": 15,
  "stock": 50,
  "id": 4,
  "createdBy": "micky",
  "updatedBy": null,
  "creationDate": "06/30/2021 15:39:45",
  "updateDate": null
}
```

#### Pagination:

#### Scheme

```
POST localhost:5001/product/pagination

{
  "PageNumber": "1",
  "TotalPageNumber": "3"
}
```

#### Result

```
{
  "productName": "Economic chicken",
  "productPrice": 15,
  "stock": 50,
  "id": 4,
  "createdBy": "micky",
  "updatedBy": null,
  "creationDate": "06/30/2021 15:39:45",
  "updateDate": null
},
{
  "productName": "school chicken",
  "productPrice": 15,
  "stock": 50,
  "id": 6,
  "createdBy": "micky",
  "updatedBy": null,
  "creationDate": "06/30/2021 15:40:17",
  "updateDate": null
},
{
  "productName": "fourth chicken",
  "productPrice": 25,
  "stock": 50,
  "id": 7,
  "createdBy": "micky",
  "updatedBy": null,
  "creationDate": "06/30/2021 15:40:22",
  "updateDate": null
}
```

#### Pagination and sorting:

#### Scheme

```
POST localhost:5001/product/pagination-sorting

{
  "PageNumber": "2",
  "TotalPageNumber": "2",
  "SortingList": ["ProductName DESC", "ProductPrice ASC"]
}
```

#### Result

```
{
  "productName": "whole chicken without garnish",
  "productPrice": 90,
  "stock": 50,
  "id": 10,
  "createdBy": "micky",
  "updatedBy": null,
  "creationDate": "06/30/2021 15:40:22",
  "updateDate": null
},
{
  "productName": "whole chicken with garnish",
  "productPrice": 100,
  "stock": 50,
  "id": 11,
  "createdBy": "micky",
  "updatedBy": null,
  "creationDate": "06/30/2021 15:40:22",
  "updateDate": null
}
```

#### Filter

#### Scheme

```
POST localhost:5001/product/filter

{
  "FilterList": ["ProductPrice=8","Stock=50"]
}
```

#### Result

```
{
  "productName": "Rice portion",
  "productPrice": 8,
  "stock": 50,
  "id": 1,
  "createdBy": "micky",
  "updatedBy": null,
  "creationDate": "06/30/2021 15:39:45",
  "updateDate": null
},
{
  "productName": "Fried potato portion",
  "productPrice": 8,
  "stock": 50,
  "id": 2,
  "createdBy": "micky",
  "updatedBy": null,
  "creationDate": "06/30/2021 15:39:45",
  "updateDate": null
},
{
  "productName": "Banana portion",
  "productPrice": 8,
  "stock": 50,
  "id": 3,
  "createdBy": "micky",
  "updatedBy": null,
  "creationDate": "06/30/2021 15:39:45",
  "updateDate": null
}
```

#### Filter like

#### Scheme

```
POST localhost:5001/product/filter-like

{
  "FilterList": ["ProductName=without garnish","Stock=50"]
}
```

```
{
  "productName": "half chicken without garnish",
  "productPrice": 40,
  "stock": 50,
  "id": 8,
  "createdBy": "micky",
  "updatedBy": null,
  "creationDate": "06/30/2021 15:40:22",
  "updateDate": null
},
{
  "productName": "whole chicken without garnish",
  "productPrice": 90,
  "stock": 50,
  "id": 10,
  "createdBy": "micky",
  "updatedBy": null,
  "creationDate": "06/30/2021 15:40:22",
  "updateDate": null
}
```

#### Filter like, pagination and sorting

#### Scheme

```
POST localhost:5001/product/filter-like/pagination-sorting

{
  "PageNumber": "0",
  "TotalPageNumber": "2",
  "FilterList": ["ProductName=half chicken"],
  "SortingList": ["Id ASC"]
}
```

#### Result

```
{
  "productName": "half chicken without garnish",
  "productPrice": 40,
  "stock": 50,
  "id": 8,
  "createdBy": "micky",
  "updatedBy": null,
  "creationDate": "06/30/2021 15:40:22",
  "updateDate": null
},
{
  "productName": "half chicken with garnish",
  "productPrice": 50,
  "stock": 50,
  "id": 9,
  "createdBy": "micky",
  "updatedBy": null,
  "creationDate": "06/30/2021 15:40:22",
  "updateDate": null
}
```
