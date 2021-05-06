using System;
using System.Data.SqlClient;

namespace WCF.DAL
{
    public class Database
    {
        static string StrConnection = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=WCF;Integrated Security=SSPI;";
        public static void ExecuteNonQuery(string sqlQuery)
        {
            SqlConnection objConnection = new SqlConnection(StrConnection);
            objConnection.Open();
            SqlCommand objCommand = new SqlCommand(sqlQuery, objConnection);
            objCommand.ExecuteNonQuery();
            objConnection.Close();
        }

        public static object ExecuteScalar(string sqlQuery)
        {
            SqlConnection objConnection = new SqlConnection(StrConnection);
            objConnection.Open();
            SqlCommand objCommand = new SqlCommand(sqlQuery, objConnection);
            object value = objCommand.ExecuteScalar();
            objConnection.Close();
            return value;
        }
    }
}
//CREATE TABLE dbo.WCF_USER(

//    [USER_ID] int IDENTITY(1,1),
//	[USER_NAME] varchar(100), 
//	PRIMARY KEY([USER_ID])
//)

//CREATE TABLE dbo.WCF_ACCOUNT(

//    [USER_ID] int,
//	[ACCOUNT_BALANCE] int,
//	FOREIGN KEY([USER_ID]) REFERENCES dbo.WCF_USER([USER_ID])
//)

//CREATE TABLE dbo.WCF_TRANSACTION(

//    [USER_ID] int,
//	[TRANSACTION_NO] varchar(300),
//	[EMI_AMOUNT] int,
//	[PAYMENT_STATUS] bit,
//	FOREIGN KEY([USER_ID]) REFERENCES dbo.WCF_USER([USER_ID])
//)


//INSERT INTO dbo.WCF_USER(USER_NAME) VALUES('SAURABH');


//TRUNCATE TABLE WCF_ACCOUNT;
//TRUNCATE TABLE WCF_TRANSACTION;
//INSERT INTO dbo.WCF_ACCOUNT([USER_ID], [ACCOUNT_BALANCE]) VALUES(1, 100);

//SELECT* FROM WCF_USER
//SELECT * FROM WCF_ACCOUNT
//SELECT * FROM WCF_TRANSACTION

