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
            NpgsqlCommand command = new NpgsqlCommand(str, connection);

            DataTable dataTable = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            adapter.SelectCommand = command;
            try
            {
                await Task<DataTable>.Run(() => adapter.Fill(dataTable));
                dataTable.Select();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Wrong command");
            }

            command.Dispose();
            return dataTable;
        }

        private async Task<int> pullRequestCommand(string str)
        {

            NpgsqlCommand command = new NpgsqlCommand(str, connection);

            int n = 0;
            try
            {
                n = Convert.ToInt32(await Task.Run(command.ExecuteScalar));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Wrong command");
            }
            
            command.Dispose();
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
