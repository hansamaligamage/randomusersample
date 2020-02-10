# A Web API built on .NET Core 3.1

## Technology stack
* .NET Core 3.1 on Visual Studio 2019
* EF Core 3.1

## Resources used
* In memory database to store data
* Random user API to get the users, you can check the documentation from here, https://randomuser.me/documentation  
* EF Core proxies to load related entities
* Http client factory to call random user APIs


## Available APIs
| Url            | Operation                              |    Usage       | Response                                                                                      
| ------------------- | --------------------------------- | ----------------------------------- | -----------------------------------     
| /users/create         | GET              | Retrieve 5 users from the random user API and save in the Inmemory datastore   | Users created : Returns 201 Created with message, 400 Bad Request returns when something goes wrong, 500 Internal server error if its my fault                                      
| /users/get        | GET                             | Retrieve all users from the datastore |  Returns 200 OK with user array, 500 Internal server error if its my fault   
       

