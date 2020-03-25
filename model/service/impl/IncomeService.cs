using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExpenseManager.model.dao;
using ExpenseManager.view;

namespace ExpenseManager.model.service.impl
{
    class IncomeService : IIncomeService
    {
        Dao dao = Dao.GetDao();
        MySqlCommand cmd;
        MySqlDataReader dataReader;
        private string query;

        public List<Income> GetAllIncomes()
        {
            List<Income> incomes = new List<Income>();
            this.dao.conn.Open();

            query = "SELECT * FROM income WHERE user_id=@userId;";

            cmd = new MySqlCommand(query, this.dao.conn);
            cmd.Parameters.AddWithValue("userId", LoginPage.userId);

            dataReader = cmd.ExecuteReader();

            Income income = null;
            
            while (dataReader.Read())
            {
                income = new Income(
                    dataReader.GetInt32(0),
                    dataReader.GetInt32(1),
                    dataReader.GetInt32(2),
                    dataReader.GetString(3),
                    dataReader.GetInt32(4),
                    dataReader.GetDateTime(5)
                );

                incomes.Add(income);
            }

            this.dao.conn.Close();

            return incomes;
        }

        public List<ChartData> GetIncomeForChart()
        {
            List<ChartData> chartDatas = new List<ChartData>();
            this.dao.conn.Open();

            query = "SELECT income_category_id, sum(amount) as total_amount FROM income WHERE user_id=@userId GROUP BY income_category_id;";

            cmd = new MySqlCommand(query, this.dao.conn);
            cmd.Parameters.AddWithValue("userId", LoginPage.userId);

            dataReader = cmd.ExecuteReader();

            ChartData chartData = null;

            while (dataReader.Read())
            {
                chartData = new ChartData(
                    dataReader.GetInt32(0),
                    dataReader.GetInt32(1)
                );

                chartDatas.Add(chartData);
            }

            this.dao.conn.Close();

            return chartDatas;
        }

        public void InsertNewIncome(int categoryId, int amount, string note, DateTime date)
        {
            this.dao.conn.Open();

            query = "INSERT INTO income(" +
                "user_id," +
                "income_category_id," +
                "amount," +
                "note," +
                "date" +
                ") VALUES(" +
                    "@userId," +
                    "@categoryId," +
                    "@amount," +
                    "@note," +
                    "@date)" +
            ";";

            cmd = new MySqlCommand(query, this.dao.conn);

            cmd.Parameters.AddWithValue("userId", LoginPage.userId);
            cmd.Parameters.AddWithValue("categoryId", categoryId);
            cmd.Parameters.AddWithValue("amount", amount);
            cmd.Parameters.AddWithValue("note", note);
            cmd.Parameters.AddWithValue("date", date);

            cmd.ExecuteNonQuery();

            this.dao.conn.Close();
        }
    }
}
