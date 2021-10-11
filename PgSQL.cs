using System;
using Npgsql;
using System.Collections.Generic;

public class PgSQL
{
    private static string Host = "Localhost";
    private static string User = "postgres";
    private static string DBname = "postgres";
    private static string Password = "0801";
    private static string Port = "5432";
    private static string connString;
    //private static string[] Columns = { "surname", "name", "middlename", "street", "phone", "created_on" };
    public struct ForOut
    {
        public int Id;
        public string Value;
    }
    public static List<ForOut> listForOut = new List<ForOut>();

    public static void ListClean(List<ForOut> list)
    {
        int cnt = 0;
        foreach(ForOut f in list)
        {
            list.RemoveAt(cnt);
        }
    }

    public static void Select(NpgsqlConnection conn, string select, List<ForOut> list)
    {
        ForOut Out = new ForOut();
        using (var command = new NpgsqlCommand($"SELECT * FROM {select}", conn))
        {

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Out.Id = reader.GetInt32(0);
                Out.Value = reader.GetString(1);
                list.Add(Out);
            }
            reader.Close();
        }
    }


    public static void Insert(NpgsqlConnection conn, string Value, string select)
    {
        using (var command = new NpgsqlCommand($"INSERT INTO {select} VALUES (DEFAULT, @v)", conn))
        {
            command.Parameters.AddWithValue("v", Value);


            int nRows = command.ExecuteNonQuery();
            Console.Out.WriteLine(String.Format("Number of rows inserted={0}", nRows));
        }
    }

    public static void BigInsert(NpgsqlConnection conn, int[] arr, string phone)
    {
        string currentDate = DateTime.Now.Date.ToString();
        using (var command = new NpgsqlCommand($"INSERT INTO clients VALUES (DEFAULT, @s, @n, @m, @str, @p)", conn))
        {
            command.Parameters.AddWithValue("s", arr[0]);
            command.Parameters.AddWithValue("n", arr[1]);
            command.Parameters.AddWithValue("m", arr[2]);
            command.Parameters.AddWithValue("str", arr[3]);
            command.Parameters.AddWithValue("p", phone);
            int nRows = command.ExecuteNonQuery();
            Console.Out.WriteLine(String.Format("Number of rows inserted={0}", nRows));
        }
    }

    public PgSQL()
	{
        connString = String.Format(
                "Server={0}; User Id={1}; Database={2}; Port={3}; Password={4};SSLMode=Prefer",
                Host,
                User,
                DBname,
                Port,
                Password);

    }

    public static string WriteToDB(List<WebSQLForms.Check> lfcheck)
    {
        listForOut.Clear();
        bool isInTable;
        string insertString = "";
        string phone = "None";
        int cnt = 0;
        int[] insertArr = new int[4];
        using (var conn = new NpgsqlConnection(connString))
        {
            conn.Open();

            foreach (WebSQLForms.Check c in lfcheck)
            {
                if (!c.IsPhone)
                {
                    isInTable = false;
                    listForOut.Clear();
                    Select(conn, c.Select, listForOut);
                    foreach (ForOut f in listForOut)
                    {
                        if (c.Value == f.Value) //Есть ли в таблице такое значение
                        {
                            insertString += $"{f.Id}, ";
                            insertArr[cnt] = f.Id;
                            isInTable = true;
                            break;
                        }
                    }
                    if (!isInTable) //Если значения нет - записать
                    {
                        Insert(conn, c.Value, c.Select);
                        //Требует оптимизации
                        listForOut.Clear();
                        Select(conn, c.Select, listForOut);
                        foreach (ForOut fo in listForOut)
                        {
                            if (c.Value == fo.Value)
                            {
                                insertString += $"{fo.Id}, ";
                                insertArr[cnt] = fo.Id;
                                isInTable = true;
                            }
                        }
                    }
                }
                else if (c.IsPhone)
                {
                    insertString += $"{c.Value}, ";
                    phone = c.Value;
                }
                cnt++;
            }
            BigInsert(conn, insertArr, phone);
        };
        return insertString;
    }
}
