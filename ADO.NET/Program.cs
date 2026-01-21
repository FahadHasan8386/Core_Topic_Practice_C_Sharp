using ADO.NET;
using System.Data;
using System.Security.Cryptography.X509Certificates;

SqlUtility sqlUtility = new SqlUtility();

// --- ১. CREATE (Insert) ---
string insertSql = "INSERT INTO Student (Name, Cgpa) VALUES (@Name, @Cgpa)";
var insertData = new Dictionary<string, object>
{
    { "@Name", "Fahad" },
    { "@Cgpa", 2.44 }
};
sqlUtility.ExecuteSql(insertSql, insertData);
Console.WriteLine("Insert Complete!");

// --- ২. READ (Select) ---
string selectSql = "SELECT * FROM Student";
DataTable data = sqlUtility.ExecuteQuery(selectSql);
foreach (DataRow row in data.Rows)
{
    Console.WriteLine($"Name: {row["Name"]}, CGPA: {row["Cgpa"]} , InActive: {row["InActive"]}");
}

// ---UPDATE ---
string updateSql = "UPDATE Student SET Cgpa = @Cgpa WHERE Name = @Name";
var updateData = new Dictionary<string, object>
{
    { "@Cgpa", 3.95 },
    { "@Name", "Fahad" }
};
sqlUtility.ExecuteSql(updateSql, updateData);
Console.WriteLine("Update Complete!");


string deleteSql = "DELETE FROM Student WHERE Name = @Name";
var deleteData = new Dictionary<string, object>
{
    {"@Name" ,  "Hasan" }
};
sqlUtility.ExecuteSql(deleteSql, deleteData);
Console.WriteLine("Delete Complete !");