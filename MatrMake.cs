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
        public MatrMake(int str_n, int col_n)
        {
            n_str = str_n;
            n_col = col_n; 
            matrix = new int[str_n, col_n];
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
            for (int j = 0; j < n_col; j++)
            {
                bool columnContainsValue = false;

                // Проверяем, содержит ли столбец заданное значение
                for (int i = 0; i < n_str; i++)
                {
                    if (matrix[i, j] == value)
                    {
                        columnContainsValue = true;
                        break;
                    }
                }

                // Если столбец содержит значение, сдвигаем все столбцы влево
                if (columnContainsValue)
                {
                    for (int k = j; k < n_col - 1; k++)
                    {
                        for (int i = 0; i < n_str; i++)
                        {
                            matrix[i, k] = matrix[i, k + 1]; // Сдвиг значений влево
                        }
                    }

                    // Обнуляем значения в последнем столбце
                    for (int i = 0; i < n_str; i++)
                    {
                        matrix[i, n_col - 1] = 0;
                    }
                    n_col--; // Уменьшаем количество столбцов
                    j--; // Уменьшаем j, чтобы проверить текущий столбец снова
                }
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
