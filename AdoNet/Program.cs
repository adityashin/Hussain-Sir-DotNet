using System.Linq.Expressions;
using Microsoft.Data.Sqlite;

//start connection with sqlite
using var connection = new SqliteConnection("Data Source=shop.db");
connection.Open();//open the connection of database

//by using this command we can execute sql queries which we are gonna perform on Database
using var command = connection.CreateCommand();

if(args.Length == 0)
{
    //we write CommandText to Perform our Sql Queries
     command.CommandText = "select productno,price,stock from productInfo";

     //execute the query and get reader
     using var reader = command.ExecuteReader();
     while(reader.Read())//it returns true or false
     {
            Console.WriteLine("{0,-6}{1,12:0.00}{2,8}",
            reader.GetInt32(0),
            reader.GetDecimal(1),
            reader.GetInt32(2));
     }
}
    else
    {
        //this else will be executed if we provide any argument
        int pno = int.Parse(args[0]);
        command.CommandText = $"update productinfo set stock = stock+5 where productno={pno}";
        int n = command.ExecuteNonQuery();

        if(n==0)//this if part will execute if there is no data
        {
            Console.WriteLine("No such Product!");
        }
    }
