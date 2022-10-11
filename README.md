# SSMS-WinForms-CRUD
## Simple program on C# Windows Forms App (.NET 6.0 Framework) that does CRUD (Create Read Update Delete) on SQL Server database.
To run this you will need:
- [Visual Studio](https://visualstudio.microsoft.com/vs/) **2022**
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) **2019**
- [SQL Server Management Studio](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16) **19 Preview 3**

Useful resources: [Installation and setup Microsoft SQL Server](https://youtu.be/dP_ZmYhNFlg) by Semyon Alekseev and [How to connect C# to SQL](https://youtu.be/Et2khGnrIqc) by IAmTimCorey

![image](https://user-images.githubusercontent.com/82185066/194978762-487c1793-4ae8-40c8-9f6f-22f9c32d8f11.png)

Database name: **CRUD**  
Table name: **dbo.People**  
Data types:  
![image](https://user-images.githubusercontent.com/82185066/194978955-174ca64a-ef59-46c0-987c-b49696d5e5a3.png)

Select Top 1000 Rows:  
![image](https://user-images.githubusercontent.com/82185066/194979022-5da20001-088c-460c-bb96-e4605b91bd9c.png)

Note: this code in theory may be used for SQL injection, to fix it change DataAccess.cs to use stored procedures instead of direct sql queries.

## Dependencies
[Dapper](https://www.nuget.org/packages/Dapper/) v1.50.2 by Sam Saffron, Marc Gravell and Nick Craver

## License
This program is licensed under the MIT License. Please read the License file to know about the usage terms and conditions.
