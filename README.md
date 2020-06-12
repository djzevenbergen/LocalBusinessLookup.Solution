# _Local Business Lookup_
#### _Epicodus Project June 12, 2020_

#### By _**DJ Zevenbergen**_



## Description

_An API build in C#/.Net Core 2.2.0 that uses token authentication, swagger documentation, and Versioning._

## Setup/Installation Requirements

* Clone this repository from GitHub.
* Ensure that MySQL and C#/.netcore2.2 is installed on your computer.
* create a file named "appsettings.json" in the LocalBusinessLookup folder
* populate it with the following text (replacing with your credentials)

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port={your default port number here!};database=local_business_lookup;uid={your mysql userid here!};pwd={your password for mysql here!};"
    },
  "AppSettings": {
    "Secret": "##add a 128 bit secret here"
  }
}
```


* create a file named "appsettings.Development.json" in the LocalBusinessLookup folder
* populate it with the following text (replacing with your credentials)

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Debug",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port={your default port number here!};database=local_business_lookup;uid={your mysql userid here!};pwd={your password for mysql here!};"
    }
}
```

* In your terminal, navigate to the project directory and run the commands to download dependencies and build the configuration.
```
  dotnet restore 
  dotnet build
``` 

* To run MySQL migrations and create a database in your MySQL installation, enter the following command in your terminal: 
```
  dotnet ef database update.
```
* run the application using 
```
dotnet run
```

* use postman to interact with the api

* A user can get all using localhost:5000/api/businesses

* a user can get a random business using localhost:5000/api/businesses/random

* To see authentication in action, you should try to do a post request in postman with no header post: localhost:5000/api/businesses:

```
{
        "name": "Joly Jands Joliday Joopla",
      "type": "restaurant",
      "description": "Holiday specialities from your favorite Latinx nuns!",
      "phoneNumber": "7878799456",
      "webSite": "https://www.reddit.com/",
      "userId": 2
}
```

* this post shouldn't work
* you must have a bearer token to post

* in postman run a Post request to localhost:5000/users/create

```
{
    "firstName": "James",
    "lastName": "Ruiz",
    "username": "DJTest",
    "password": "test"
}

```

* once you've successfully created this account you can do a post request to localhost:5000/users/authenticate

```
{

    "username": "DJTest",
    "password": "test"
}

```

* this request should return a token.  copy the token and put it in the authorization header of a post request to localhost:5000/api/businesses

```
{
        "name": "Hi Ho Silver's Horse Supplies",
      "type": "shop",
      "description": "Specialty horse clothing!",
      "phoneNumber": "5555555555",
      "webSite": "https://www.reddit.com/",
      "userId": 2
}
```
* you should now be able to run a get localhost:3000/api/businesses and see that your new business has been added

* to see versioning at work, you can add run get requests to http://localhost:5000/api/businesses/?api-version=2.0 and http://localhost:5000/api/businesses/?api-version=1.0
* the response headers should contains different versions



* This API uses Swagger. 
* You're going to need to comment out lines 137-258 of business controller and rebuild to see it work.

* To launch the Swagger/OpenAPI utility in your browser, from the project directory in your terminal, enter dotnet run and open a browser page at localhost:5000.  You can now see all API routes grouped by controller.  Clicking on a route will expand it and show details of that route, and give you the option to "Try It Out."



## Known Bugs

Swagger and versioning don't work at the same time

There are no known bugs at the time of this update.

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue] here on GitHub._

## Technologies Used

* C#
* .NET Core
* ASP.NET Core MVC
* MySQL
* Entity
* Identity
* MSBuild
* Git and GitHub
* Swagger/OpenAPI
* Versioning

### User Story

* As a user, I want to be able GET all businesses 
* As a user, I want to be able to POST businesses.
* As a user, I want to be able to PUT and DELETE businesses that I have created.
* As a user, I want to be able to look up businesses by name, type, description, phone number and website.
* As a user, I want error messages to tell me what I did wrong.
* As a user, I want to be able to create a user profile and log in so that I can add, see, edit, and delete my businesses.

* On get request, return dictionary with key value pairs of ```{{"version", "version 1}, {"types", List<strings>{"types","businesses"}}, {"response", List<Remedy>{}}```



### License
This software is licensed under the MIT license.

Copyright (c) 2020 **_DJ Zevenbergen_**
