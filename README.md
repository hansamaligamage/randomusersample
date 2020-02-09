# A Web API built on .NET Core 3.1
This project is built using Visual Studio 2019 on .NET Core 3.1 and EF Core 3.1, to store the data used In memory database available in the EF Core
It has used Random user API, you can check the documentation from here, https://randomuser.me/documentation  

## Available APIs
| Resource            | Operation                              | Url                                 | PUT                                           | DELETE                           |
| ------------------- | --------------------------------- | ----------------------------------- | --------------------------------------------- | -------------------------------- |
| /users/create         | Create a new customer             | Retrieve all customers              | Bulk update of customers                      | Remove all customers             |
| /customers/1        | Error                             | Retrieve the details for customer 1 | Update the details of customer 1 if it exists | Remove customer 1                |
| /customers/1/orders | Create a new order for customer 1 | Retrieve all orders for customer 1  | Bulk update of orders for customer 1          | Remove all orders for customer 1 |

