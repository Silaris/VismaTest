# VismaTest
Expected result


![изображение](https://github.com/Silaris/VismaTest/assets/28263837/b34335cf-9afd-4c79-9ed9-a4a842c2bdad)


Database:

VismaTestDB + Postgress DB

Connection string: appsettings.json (TestDBConnection)

DB models in models, related model creation migration Initial. I enjoy using data annotations => I have added them to models. 

DB is filled with data through seed migration (Seed). Created multiple managers and developers with different salaries and added them with SQL script. 

Backend:

VismaTest.Server (ASP.Net core app)

DB context initialized in the Program.cs using context from VismaTestDB.

Controllers have two methods: 

1) Get for all developers
2) GetHighSalaries with LINQ filtering for salaries greater than manager salaries (output contains related manager data as well).

Frontend:

VismaTest.Client (ASP.Net core app)

Angular app. Here I obeyed the common practice of creating additional components, services, and routing modules due to the simplicity of the task.

Data from the server is retrieved at app.component immediately and transformed into a table in app.component.html. 

In proxy.config.json request is redirected to the server URI.
