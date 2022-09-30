# Project Title

Movie Web API

## Description

A RESTful API web service that accepts HTTP requests and returns responses based on the request. 

* C - Create a new movie 
* R - View all movies
* U - Update a movie
* D - Delete a movie

### Built With

* C#
* .NET Core Framework

### Dependencies

* Entity Framework Core
* MySQL Server

### Before Installing
* Need .NET 6.0 SDK
* Here is a [Link](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).
* Also Microsoft SQL Server Express.
* Here is a [Link](https://www.microsoft.com/en-us/sql-server/sql-server-2019).
* Finally I used Visual Studio 2022: Community Version
* Here is a [Link](https://visualstudio.microsoft.com/vs/#download).
* Once MongoDB and Node.js are installed you start cloning the repository.

### Installing

* Clone repository git clone 

```
https://github.com/whitneyharper/MoviesAPI.git
```

## API Calls

| Type     | URI            | Parameter    | Description                       |
| -------- | -------------  | ------------ | --------------------------------- | 
| GET      | /movies        |              | return all movies in db           | 
| GET      | /movies/:id    | movie id     | return specific movie by id       | 
| POST     | /movies        |              | create a new movie                |  
| PUT      | /movies   /:id | movie id     | update movie by specific id       |  
| DELETE   | /movies/:id    | movie id     | delete movie by specific id       | 


  
## Authors

Contributors names and contact info

ex. Whitney Harper  
