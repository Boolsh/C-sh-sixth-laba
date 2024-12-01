using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._2
{
    class MatrMake
    {
        int n_str,     //количество строк 
            n_col;     //количество столбцов 
        int[,] matrix; // обрабатываемая матрица
        public MatrMake(int n)
        {
            n_str = n;
            n_col = n; // на входе матрица квадратная 
            matrix = new int[n, n];
        }
        //матрица из DataGridView 
        public void GridToMatrix(DataGridView dgv)
        {
            DataGridViewCell txtCell;
            for (int i = 0; i < n_str; i++)
            {
                for (int j = 0; j < n_col; j++)
                {
                    txtCell = dgv.Rows[i].Cells[j];
                    string s = txtCell.Value.ToString();
                    if (s == "")
                        matrix[i, j] = 0;
                    else
                        matrix[i, j] = Int32.Parse(s);
                }
            }
        }
        //вывод матрицы в DataGridView 
        public void MatrixToGrid(DataGridView dgv)
        {
            //установка размеров 
            int i;
            DataTable matr = new DataTable("matr");
            DataColumn[] cols = new DataColumn[n_col];
            for (i = 0; i < n_col; i++)
            {
                cols[i] = new DataColumn(i.ToString());
                matr.Columns.Add(cols[i]);
            }
            for (i = 0; i < n_str; i++)
            {
                DataRow newRow;
                newRow = matr.NewRow();
                matr.Rows.Add(newRow);
            }
            dgv.DataSource = matr;
            for (i = 0; i < n_col; i++)
                dgv.Columns[i].Width = 50;
            //занесение значений
            DataGridViewCell txtCell;
            for (i = 0; i < n_str; i++)
            {
                for (int j = 0; j < n_col; j++)
                {
                    txtCell = dgv.Rows[i].Cells[j];
                    txtCell.Value = matrix[i, j].ToString();
                }
            }
        }
        public void DelCol(int value) // Метод для удаления столбцов, содержащих заданное значение
        {
            List<int> columnsToRemove = new List<int>();

            // Определяем, какие столбцы нужно удалить
            for (int j = 0; j < n_col; j++)
            {
                for (int i = 0; i < n_str; i++)
                {
                    if (matrix[i, j] == value)
                    {
                        columnsToRemove.Add(j);
                        break;
                    }
                }
            }

            // Удаляем столбцы с конца, чтобы не нарушать индексы
            for (int i = columnsToRemove.Count - 1; i >= 0; i--)
            {
                int col = columnsToRemove[i]; // Получаем индекс столбца для удаления
                for (int j = 0; j < n_str; j++)
                {
                    for (int k = col; k < n_col - 1; k++)
                    {
                        matrix[j, k] = matrix[j, k + 1];
                    }
                    matrix[j, n_col - 1] = 0; // Обнуляем последний столбец
                }
                n_col--; // Уменьшаем количество столбцов
            }
        }
        public int GetCol()
        {
            return n_col;
        }
        public int GetStr()
        {
            return n_str;
        }
    }
}
