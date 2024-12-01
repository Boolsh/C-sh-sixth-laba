namespace lab6._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBoxSize = new TextBox();
            btnCreate = new Button();
            btnLoadMatrix = new Button();
            btnTask = new Button();
            btnSaveOriginal = new Button();
            btnSaveResult = new Button();
            dataGridViewInput = new DataGridView();
            dataGridViewResult = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBoxSize
            // 
            textBoxSize.ForeColor = Color.Gray;
            textBoxSize.Location = new Point(18, 13);
            textBoxSize.Margin = new Padding(2, 2, 2, 2);
            textBoxSize.Multiline = true;
            textBoxSize.Name = "textBoxSize";
            textBoxSize.Size = new Size(126, 39);
            textBoxSize.TabIndex = 0;
            textBoxSize.Text = "Размер матрицы";
            textBoxSize.Enter += textBoxSize_Enter;
            textBoxSize.Leave += textBoxSize_Leave;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(175, 13);
            btnCreate.Margin = new Padding(2, 2, 2, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(81, 37);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Создать";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnLoadMatrix
            // 
            btnLoadMatrix.Location = new Point(286, 13);
            btnLoadMatrix.Margin = new Padding(2, 2, 2, 2);
            btnLoadMatrix.Name = "btnLoadMatrix";
            btnLoadMatrix.Size = new Size(154, 37);
            btnLoadMatrix.TabIndex = 2;
            btnLoadMatrix.Text = "Загрузить матрицу";
            btnLoadMatrix.UseVisualStyleBackColor = true;
            btnLoadMatrix.Click += btnLoadMatrix_Click;
            // 
            // btnTask
            // 
            btnTask.Location = new Point(464, 13);
            btnTask.Margin = new Padding(2, 2, 2, 2);
            btnTask.Name = "btnTask";
            btnTask.Size = new Size(195, 37);
            btnTask.TabIndex = 3;
            btnTask.Text = "Удалить столбцы, с заданным значением";
            btnTask.UseVisualStyleBackColor = true;
            btnTask.Click += btnTask_Click;
            // 
            // btnSaveOriginal
            // 
            btnSaveOriginal.Location = new Point(64, 79);
            btnSaveOriginal.Margin = new Padding(2, 2, 2, 2);
            btnSaveOriginal.Name = "btnSaveOriginal";
            btnSaveOriginal.Size = new Size(141, 20);
            btnSaveOriginal.TabIndex = 4;
            btnSaveOriginal.Text = "Сохраниь исходную";
            btnSaveOriginal.UseVisualStyleBackColor = true;
            btnSaveOriginal.Click += btnSaveOriginal_Click;
            // 
            // btnSaveResult
            // 
            btnSaveResult.Location = new Point(508, 79);
            btnSaveResult.Margin = new Padding(2, 2, 2, 2);
            btnSaveResult.Name = "btnSaveResult";
            btnSaveResult.Size = new Size(134, 20);
            btnSaveResult.TabIndex = 5;
            btnSaveResult.Text = "Сохранить";
            btnSaveResult.UseVisualStyleBackColor = true;
            btnSaveResult.Click += btnSaveResult_Click;
            // 
            // dataGridViewInput
            // 
            dataGridViewInput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput.Location = new Point(18, 108);
            dataGridViewInput.Margin = new Padding(2, 2, 2, 2);
            dataGridViewInput.Name = "dataGridViewInput";
            dataGridViewInput.RowHeadersWidth = 62;
            dataGridViewInput.Size = new Size(377, 194);
            dataGridViewInput.TabIndex = 6;
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Location = new Point(464, 108);
            dataGridViewResult.Margin = new Padding(2, 2, 2, 2);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersWidth = 62;
            dataGridViewResult.Size = new Size(381, 194);
            dataGridViewResult.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 326);
            Controls.Add(dataGridViewResult);
            Controls.Add(dataGridViewInput);
            Controls.Add(btnSaveResult);
            Controls.Add(btnSaveOriginal);
            Controls.Add(btnTask);
            Controls.Add(btnLoadMatrix);
            Controls.Add(btnCreate);
            Controls.Add(textBoxSize);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Matrix Manipulation";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBoxSize;
        private Button btnCreate;
        private Button btnLoadMatrix;
        private Button btnTask;
        private Button btnSaveOriginal;
        private Button btnSaveResult;
        private DataGridView dataGridViewInput;
        private DataGridView dataGridViewResult;
    }
}
