namespace Proooooooooooject
{
    partial class ToDos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnplust = new System.Windows.Forms.Button();
            this.lblTodot = new System.Windows.Forms.Label();
            this.dataGridViewTodos = new System.Windows.Forms.DataGridView();
            this.txtTodot = new System.Windows.Forms.TextBox();
            this.btnGoalst = new System.Windows.Forms.Button();
            this.btnRolest = new System.Windows.Forms.Button();
            this.btnTodot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodos)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(260, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // btnplust
            // 
            this.btnplust.Location = new System.Drawing.Point(496, 140);
            this.btnplust.Name = "btnplust";
            this.btnplust.Size = new System.Drawing.Size(75, 23);
            this.btnplust.TabIndex = 37;
            this.btnplust.Text = "+";
            this.btnplust.UseVisualStyleBackColor = true;
            this.btnplust.Click += new System.EventHandler(this.btnplust_Click);
            // 
            // lblTodot
            // 
            this.lblTodot.AutoSize = true;
            this.lblTodot.Location = new System.Drawing.Point(257, 69);
            this.lblTodot.Name = "lblTodot";
            this.lblTodot.Size = new System.Drawing.Size(41, 13);
            this.lblTodot.TabIndex = 36;
            this.lblTodot.Text = "To - do";
            // 
            // dataGridViewTodos
            // 
            this.dataGridViewTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTodos.Location = new System.Drawing.Point(148, 169);
            this.dataGridViewTodos.Name = "dataGridViewTodos";
            this.dataGridViewTodos.Size = new System.Drawing.Size(458, 195);
            this.dataGridViewTodos.TabIndex = 32;
            // 
            // txtTodot
            // 
            this.txtTodot.Location = new System.Drawing.Point(360, 66);
            this.txtTodot.Name = "txtTodot";
            this.txtTodot.Size = new System.Drawing.Size(100, 20);
            this.txtTodot.TabIndex = 29;
            // 
            // btnGoalst
            // 
            this.btnGoalst.Location = new System.Drawing.Point(26, 169);
            this.btnGoalst.Name = "btnGoalst";
            this.btnGoalst.Size = new System.Drawing.Size(75, 23);
            this.btnGoalst.TabIndex = 25;
            this.btnGoalst.Text = "Goals";
            this.btnGoalst.UseVisualStyleBackColor = true;
            // 
            // btnRolest
            // 
            this.btnRolest.Location = new System.Drawing.Point(26, 81);
            this.btnRolest.Name = "btnRolest";
            this.btnRolest.Size = new System.Drawing.Size(75, 23);
            this.btnRolest.TabIndex = 24;
            this.btnRolest.Text = "Roles";
            this.btnRolest.UseVisualStyleBackColor = true;
            // 
            // btnTodot
            // 
            this.btnTodot.Location = new System.Drawing.Point(26, 265);
            this.btnTodot.Name = "btnTodot";
            this.btnTodot.Size = new System.Drawing.Size(75, 23);
            this.btnTodot.TabIndex = 26;
            this.btnTodot.Text = "To - dos";
            this.btnTodot.UseVisualStyleBackColor = true;
            // 
            // ToDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 402);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnplust);
            this.Controls.Add(this.lblTodot);
            this.Controls.Add(this.dataGridViewTodos);
            this.Controls.Add(this.txtTodot);
            this.Controls.Add(this.btnGoalst);
            this.Controls.Add(this.btnRolest);
            this.Controls.Add(this.btnTodot);
            this.Name = "ToDos";
            this.Text = "ToDos";
            this.Load += new System.EventHandler(this.ToDos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnplust;
        private System.Windows.Forms.Label lblTodot;
        private System.Windows.Forms.DataGridView dataGridViewTodos;
        private System.Windows.Forms.TextBox txtTodot;
        private System.Windows.Forms.Button btnGoalst;
        private System.Windows.Forms.Button btnRolest;
        private System.Windows.Forms.Button btnTodot;
    }
}