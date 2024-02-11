using Dapper;
using LessonDapper;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
 

string ConStr = "Data Source=DESKTOP-SDREM5J\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;";


var connection = new SqlConnection(ConStr);

connection.Open();


string insertQuery = "Insert INTO Authors (Id,FirstName, LastName) Values (80 , 'Huseyn9','Dadashov1')";
string insertQuery8 = "Insert INTO Authors (Id,FirstName, LastName) Values (81 , 'Huseyn','Dadashov2')";
string insertQuery7 = "Insert INTO Authors (Id,FirstName, LastName) Values (82 , 'Huseyn1','Dadashov3')";
string insertQuery6 = "Insert INTO Authors (Id,FirstName, LastName) Values (83 , 'Huseyn2','Dadashov4')";
string insertQuery5 = "Insert INTO Authors (Id,FirstName, LastName) Values (84 , 'Huseyn3','Dadashov5')";
string insertQuery4 = "Insert INTO Authors (Id,FirstName, LastName) Values (85 , 'Huseyn4','Dadashov6')";
string insertQuery3 = "Insert INTO Authors (Id,FirstName, LastName) Values (86 , 'Huseyn5','Dadashov7')";
string insertQuery2 = "Insert INTO Authors (Id,FirstName, LastName) Values (87 , 'Huseyn6','Dadashov8')";
string insertQuery1 = "Insert INTO Authors (Id,FirstName, LastName) Values (88 , 'Huseyn7','Dadashov9')";
string insertQuery9 = "Insert INTO Authors (Id,FirstName, LastName) Values (88 , 'Huseyn8','Dadashov10')";

connection.Execute(insertQuery);
connection.Execute(insertQuery1);
connection.Execute(insertQuery2);
connection.Execute(insertQuery3);
connection.Execute(insertQuery4);
connection.Execute(insertQuery5);
connection.Execute(insertQuery6);
connection.Execute(insertQuery7);
connection.Execute(insertQuery8);
connection.Execute(insertQuery9);