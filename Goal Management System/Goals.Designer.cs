namespace Proooooooooooject
{
    partial class Goals
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
            this.dataGridViewG = new System.Windows.Forms.DataGridView();
            this.AddTo_dos = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnPlusg = new System.Windows.Forms.Button();
            this.txtGoalg = new System.Windows.Forms.TextBox();
            this.lblGoalg = new System.Windows.Forms.Label();
            this.btnTodog = new System.Windows.Forms.Button();
            this.btnGoalsg = new System.Windows.Forms.Button();
            this.btnRolesg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewG)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewG
            // 
            this.dataGridViewG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddTo_dos});
            this.dataGridViewG.Location = new System.Drawing.Point(169, 131);
            this.dataGridViewG.Name = "dataGridViewG";
            this.dataGridViewG.Size = new System.Drawing.Size(429, 206);
            this.dataGridViewG.TabIndex = 23;
            this.dataGridViewG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewG_CellContentClick);
            // 
            // AddTo_dos
            // 
            this.AddTo_dos.HeaderText = "Add To_dos";
            this.AddTo_dos.Name = "AddTo_dos";
            this.AddTo_dos.Text = "Add To_dos";
            this.AddTo_dos.UseColumnTextForLinkValue = true;
            // 
            // btnPlusg
            // 
            this.btnPlusg.Location = new System.Drawing.Point(460, 74);
            this.btnPlusg.Name = "btnPlusg";
            this.btnPlusg.Size = new System.Drawing.Size(75, 23);
            this.btnPlusg.TabIndex = 22;
            this.btnPlusg.Text = "+";
            this.btnPlusg.UseVisualStyleBackColor = true;
            this.btnPlusg.Click += new System.EventHandler(this.btnPlusg_Click);
            // 
            // txtGoalg
            // 
            this.txtGoalg.Location = new System.Drawing.Point(315, 76);
            this.txtGoalg.Name = "txtGoalg";
            this.txtGoalg.Size = new System.Drawing.Size(100, 20);
            this.txtGoalg.TabIndex = 21;
            this.txtGoalg.TextChanged += new System.EventHandler(this.txtGoalg_TextChanged);
            // 
            // lblGoalg
            // 
            this.lblGoalg.AutoSize = true;
            this.lblGoalg.Location = new System.Drawing.Point(225, 79);
            this.lblGoalg.Name = "lblGoalg";
            this.lblGoalg.Size = new System.Drawing.Size(29, 13);
            this.lblGoalg.TabIndex = 19;
            this.lblGoalg.Text = "Goal";
            this.lblGoalg.Click += new System.EventHandler(this.lblGoalg_Click);
            // 
            // btnTodog
            // 
            this.btnTodog.Location = new System.Drawing.Point(26, 275);
            this.btnTodog.Name = "btnTodog";
            this.btnTodog.Size = new System.Drawing.Size(75, 23);
            this.btnTodog.TabIndex = 14;
            this.btnTodog.Text = "To - dos";
            this.btnTodog.UseVisualStyleBackColor = true;
            this.btnTodog.Click += new System.EventHandler(this.btnTodog_Click);
            // 
            // btnGoalsg
            // 
            this.btnGoalsg.Location = new System.Drawing.Point(26, 174);
            this.btnGoalsg.Name = "btnGoalsg";
            this.btnGoalsg.Size = new System.Drawing.Size(75, 23);
            this.btnGoalsg.TabIndex = 13;
            this.btnGoalsg.Text = "Goals";
            this.btnGoalsg.UseVisualStyleBackColor = true;
            this.btnGoalsg.Click += new System.EventHandler(this.btnGoalsg_Click);
            // 
            // btnRolesg
            // 
            this.btnRolesg.Location = new System.Drawing.Point(26, 76);
            this.btnRolesg.Name = "btnRolesg";
            this.btnRolesg.Size = new System.Drawing.Size(75, 23);
            this.btnRolesg.TabIndex = 12;
            this.btnRolesg.Text = "Roles";
            this.btnRolesg.UseVisualStyleBackColor = true;
            this.btnRolesg.Click += new System.EventHandler(this.btnRolesg_Click);
            // 
            // Goals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 398);
            this.Controls.Add(this.dataGridViewG);
            this.Controls.Add(this.btnPlusg);
            this.Controls.Add(this.txtGoalg);
            this.Controls.Add(this.lblGoalg);
            this.Controls.Add(this.btnTodog);
            this.Controls.Add(this.btnGoalsg);
            this.Controls.Add(this.btnRolesg);
            this.Name = "Goals";
            this.Text = "Goals";
            this.Load += new System.EventHandler(this.Goals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewG;
        private System.Windows.Forms.Button btnPlusg;
        private System.Windows.Forms.TextBox txtGoalg;
        private System.Windows.Forms.Label lblGoalg;
        private System.Windows.Forms.Button btnTodog;
        private System.Windows.Forms.Button btnGoalsg;
        private System.Windows.Forms.Button btnRolesg;
        private System.Windows.Forms.DataGridViewLinkColumn AddTo_dos;
    }
}