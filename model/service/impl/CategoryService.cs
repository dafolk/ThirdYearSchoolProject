using ExpenseManager.model.dao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.model.service.impl
{
    class CategoryService : ICategoryService
    {
        Dao dao = Dao.GetDao();
        MySqlCommand cmd;
        MySqlDataReader dataReader;
        private string query;
        private IncomeCategory incomeCategory = null;
        private OutcomeCategory outcomeCategory = null;
        private List<IncomeCategory> incomeCategories = new List<IncomeCategory>();
        private List<OutcomeCategory> outcomeCategories = new List<OutcomeCategory>();

        public List<IncomeCategory> GetAllIncomeCategories()
        {
            this.dao.conn.Open();

            query = "SELECT * FROM income_category;";

            cmd = new MySqlCommand(query, this.dao.conn);

            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                incomeCategory = new IncomeCategory(
                    dataReader.GetInt32(0),
                    dataReader.GetString(1)
                );

                incomeCategories.Add(incomeCategory);
            }

            this.dao.conn.Close();

            return incomeCategories;
        }

        public List<OutcomeCategory> GetAllOutcomeCategories()
        {
            this.dao.conn.Open();

            query = "SELECT * FROM outcome_category;";

            cmd = new MySqlCommand(query, this.dao.conn);

            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                outcomeCategory = new OutcomeCategory(
                    dataReader.GetInt32(0),
                    dataReader.GetString(1)
                );

                outcomeCategories.Add(outcomeCategory);
            }

            this.dao.conn.Close();

            return outcomeCategories;
        }

        public IncomeCategory GetIncomeCategoryById(int id)
        {
            this.dao.conn.Open();

            query = "SELECT * FROM income_category WHERE id = @id;";

            cmd = new MySqlCommand(query, this.dao.conn);
            cmd.Parameters.AddWithValue("id", id);

            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                incomeCategory = new IncomeCategory(
                    dataReader.GetInt32(0),
                    dataReader.GetString(1)
                );
            }

            this.dao.conn.Close();

            return incomeCategory;
        }

        public IncomeCategory GetIncomeCategoryByName(string name)
        {
            this.dao.conn.Open();

            query = "SELECT * FROM income_category WHERE name = @name;";

            cmd = new MySqlCommand(query, this.dao.conn);
            cmd.Parameters.AddWithValue("name", name);

            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                incomeCategory = new IncomeCategory(
                    dataReader.GetInt32(0),
                    dataReader.GetString(1)
                );
            }

            this.dao.conn.Close();

            return incomeCategory;
        }

        public OutcomeCategory GetOutcomeCategoryById(int id)
        {
            this.dao.conn.Open();

            query = "SELECT * FROM outcome_category WHERE id = @id;";

            cmd = new MySqlCommand(query, this.dao.conn);
            cmd.Parameters.AddWithValue("id", id);

            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                outcomeCategory = new OutcomeCategory(
                    dataReader.GetInt32(0),
                    dataReader.GetString(1)
                );
            }

            this.dao.conn.Close();

            return outcomeCategory;
        }

        public OutcomeCategory GetOutcomeCategoryByName(string name)
        {
            this.dao.conn.Open();

            query = "SELECT * FROM outcome_category WHERE name = @name;";

            cmd = new MySqlCommand(query, this.dao.conn);
            cmd.Parameters.AddWithValue("name", name);

            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                outcomeCategory = new OutcomeCategory(
                    dataReader.GetInt32(0),
                    dataReader.GetString(1)
                );
            }

            this.dao.conn.Close();

            return outcomeCategory;
        }
    }
}
