using ExpenseManager.model.dao;
using ExpenseManager.view;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.model.service.impl
{
    class OutcomeService : IOutcomeService
    {
        Dao dao = Dao.GetDao();
        MySqlCommand cmd;
        MySqlDataReader dataReader;
        private string query;

        public List<Outcome> GetAllOutcomes()
        {
            List<Outcome> outcomes = new List<Outcome>();
            this.dao.conn.Open();

            query = "SELECT * FROM outcome WHERE user_id=@userId;";

            cmd = new MySqlCommand(query, this.dao.conn);
            cmd.Parameters.AddWithValue("userId", LoginPage.userId);

            dataReader = cmd.ExecuteReader();

            Outcome outcome = null;

            while (dataReader.Read())
            {
                outcome = new Outcome(
                    dataReader.GetInt32(0),
                    dataReader.GetInt32(1),
                    dataReader.GetInt32(2),
                    dataReader.GetString(3),
                    dataReader.GetInt32(4),
                    dataReader.GetDateTime(5)
                );

                outcomes.Add(outcome);
            }

            this.dao.conn.Close();

            return outcomes;
        }

        public List<ChartData> GetOutcomeForChart()
        {
            List<ChartData> chartDatas = new List<ChartData>();
            this.dao.conn.Open();

            query = "SELECT outcome_category_id, sum(amount) as total_amount FROM outcome WHERE user_id=@userId GROUP BY outcome_category_id;";

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

        public void InsertNewOutcome(int categoryId, int amount, string note, DateTime date)
        {
            this.dao.conn.Open();

            query = "INSERT INTO outcome(" +
                "user_id," +
                "outcome_category_id," +
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
