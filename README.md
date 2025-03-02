
Setup Instructions


1) Install:
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [MySQL Server](https://dev.mysql.com/downloads/mysql/)
- [MySQL Workbench](https://dev.mysql.com/downloads/workbench/)

---

2) Clone the Repository

git clone https://github.com/your-username/CrudProject.git
cd CrudProject

---

3) Configure Database Connection
Open appsettings.json.
Update the connection string with your MySQL information:

"ConnectionStrings": {
      "DefaultConnection": "server=127.0.0.1;database=crudschema;user=root;password=12345678;SslMode=Preferred;"
    }
    
---

4) Save the file.

---

5) Apply Database Migrations

dotnet ef migrations add InitialCreate
dotnet ef database update

---

6) Run the Project

dotnet run