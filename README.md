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
| Url            | Operation                              |    Usage                              |                                                               
| ------------------- | --------------------------------- | ----------------------------------- | 
| /users/create         | GET              | Retrieve 5 users from the random user API and save in the in memory datastore          |                             
| /users/get        | GET                             | Retrieve all users from the datastore | 
| /customers/1/orders | Create a new order for customer 1 | Retrieve all orders for customer 1  |          

