using Npgsql;
using Npgsql.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife_Pt2.Database
{
    public class DBConnector
    {
        private static string connectionString = "Host=localhost;Port=5432;Database=healthylife;Username=healthylife;Password=healthylife";
        public static NpgsqlConnection connection { get; } = new NpgsqlConnection(connectionString);
        
        Mutex mutex = new Mutex();
        /*
        public DBConnector()
        {
            this.Open();
        }
        ~DBConnector()
        {
            this.Close();
        }
        */
        public NpgsqlConnection Open()
        {
            try
            {
                connection.Open();
            } catch (Exception ex) { }
            
            return connection;
        }

        public async Task<int> insert(string str)
        {
            return await pullRequestCommand(str);
        }

        public async Task remove(string str)
        {
            await pullRequestCommand(str);
        }

        public async Task update(string str)
        {
            await pullRequestCommand(str);
        }

        public async Task<DataTable> select(string str)
        {

            mutex.WaitOne();
            NpgsqlCommand command = new NpgsqlCommand(str, connection);

            DataTable dataTable = new DataTable();
            
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;
            
            await Task.Run(() => {
                try
                {
                    adapter.Fill(dataTable);
                    dataTable.Select();
                }
                catch (Npgsql.NpgsqlOperationInProgressException ex){
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    //throw new Exception("Wrong command");
                }
                command.Dispose();
            });

            mutex.ReleaseMutex();
            return dataTable;
        }

        private async Task<int> pullRequestCommand(string str)
        {
            mutex.WaitOne();
            NpgsqlCommand command = new NpgsqlCommand(str, connection);

            int n = 0;
            await Task.Run(() =>
            {
                try
                {
                    n = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Npgsql.NpgsqlOperationInProgressException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    //throw new Exception("Wrong command");
                }

                command.Dispose();
            });
            mutex.ReleaseMutex();
            return n;
        }

        public NpgsqlConnection Close()
        {
            try
            {
                connection.Close();
            } catch (Exception ex) { }
            
            return connection;
        }
    }
}
