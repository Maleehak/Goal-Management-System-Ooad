namespace Proooooooooooject
{
    partial class Roles
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
            this.dataGridViewRoles = new System.Windows.Forms.DataGridView();
            this.Add_Goals = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lblroleTyper = new System.Windows.Forms.Label();
            this.lblRoleNamer = new System.Windows.Forms.Label();
            this.txtRoleNamer = new System.Windows.Forms.TextBox();
            this.btnTodor = new System.Windows.Forms.Button();
            this.btnGoalsr = new System.Windows.Forms.Button();
            this.btnRolesr = new System.Windows.Forms.Button();
            this.btAddr = new System.Windows.Forms.Button();
            this.comboRoleTyper = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRoles
            // 
            this.dataGridViewRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Add_Goals});
            this.dataGridViewRoles.Location = new System.Drawing.Point(133, 183);
            this.dataGridViewRoles.Name = "dataGridViewRoles";
            this.dataGridViewRoles.Size = new System.Drawing.Size(494, 178);
            this.dataGridViewRoles.TabIndex = 18;
            this.dataGridViewRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoles_CellContentClick);
            // 
            // Add_Goals
            // 
            this.Add_Goals.HeaderText = "Add Goals";
            this.Add_Goals.Name = "Add_Goals";
            this.Add_Goals.Text = "Add Goals";
            this.Add_Goals.UseColumnTextForLinkValue = true;
            // 
            // lblroleTyper
            // 
            this.lblroleTyper.AutoSize = true;
            this.lblroleTyper.Location = new System.Drawing.Point(241, 123);
            this.lblroleTyper.Name = "lblroleTyper";
            this.lblroleTyper.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblroleTyper.Size = new System.Drawing.Size(56, 13);
            this.lblroleTyper.TabIndex = 17;
            this.lblroleTyper.Text = "Role Type";
            // 
            // lblRoleNamer
            // 
            this.lblRoleNamer.AutoSize = true;
            this.lblRoleNamer.Location = new System.Drawing.Point(241, 72);
            this.lblRoleNamer.Name = "lblRoleNamer";
            this.lblRoleNamer.Size = new System.Drawing.Size(60, 13);
            this.lblRoleNamer.TabIndex = 16;
            this.lblRoleNamer.Text = "Role Name";
            // 
            // txtRoleNamer
            // 
            this.txtRoleNamer.Location = new System.Drawing.Point(384, 65);
            this.txtRoleNamer.Name = "txtRoleNamer";
            this.txtRoleNamer.Size = new System.Drawing.Size(100, 20);
            this.txtRoleNamer.TabIndex = 15;
            // 
            // btnTodor
            // 
            this.btnTodor.Location = new System.Drawing.Point(20, 289);
            this.btnTodor.Name = "btnTodor";
            this.btnTodor.Size = new System.Drawing.Size(75, 23);
            this.btnTodor.TabIndex = 13;
            this.btnTodor.Text = "To - dos";
            this.btnTodor.UseVisualStyleBackColor = true;
            // 
            // btnGoalsr
            // 
            this.btnGoalsr.Location = new System.Drawing.Point(20, 209);
            this.btnGoalsr.Name = "btnGoalsr";
            this.btnGoalsr.Size = new System.Drawing.Size(75, 23);
            this.btnGoalsr.TabIndex = 12;
            this.btnGoalsr.Text = "Goals";
            this.btnGoalsr.UseVisualStyleBackColor = true;
            // 
            // btnRolesr
            // 
            this.btnRolesr.Location = new System.Drawing.Point(20, 118);
            this.btnRolesr.Name = "btnRolesr";
            this.btnRolesr.Size = new System.Drawing.Size(75, 23);
            this.btnRolesr.TabIndex = 11;
            this.btnRolesr.Text = "Roles";
            this.btnRolesr.UseVisualStyleBackColor = true;
            // 
            // btAddr
            // 
            this.btAddr.Location = new System.Drawing.Point(467, 154);
            this.btAddr.Name = "btAddr";
            this.btAddr.Size = new System.Drawing.Size(38, 23);
            this.btAddr.TabIndex = 20;
            this.btAddr.Text = "Add";
            this.btAddr.UseVisualStyleBackColor = true;
            this.btAddr.Click += new System.EventHandler(this.btAddr_Click);
            // 
            // comboRoleTyper
            // 
            this.comboRoleTyper.FormattingEnabled = true;
            this.comboRoleTyper.Items.AddRange(new object[] {
            "Self",
            "Social",
            "Work"});
            this.comboRoleTyper.Location = new System.Drawing.Point(384, 115);
            this.comboRoleTyper.Name = "comboRoleTyper";
            this.comboRoleTyper.Size = new System.Drawing.Size(121, 21);
            this.comboRoleTyper.TabIndex = 19;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 403);
            this.Controls.Add(this.dataGridViewRoles);
            this.Controls.Add(this.lblroleTyper);
            this.Controls.Add(this.lblRoleNamer);
            this.Controls.Add(this.txtRoleNamer);
            this.Controls.Add(this.btnTodor);
            this.Controls.Add(this.btnGoalsr);
            this.Controls.Add(this.btnRolesr);
            this.Controls.Add(this.btAddr);
            this.Controls.Add(this.comboRoleTyper);
            this.Name = "Roles";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.Roles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRoles;
        private System.Windows.Forms.Label lblroleTyper;
        private System.Windows.Forms.Label lblRoleNamer;
        private System.Windows.Forms.TextBox txtRoleNamer;
        private System.Windows.Forms.Button btnTodor;
        private System.Windows.Forms.Button btnGoalsr;
        private System.Windows.Forms.Button btnRolesr;
        private System.Windows.Forms.Button btAddr;
        private System.Windows.Forms.ComboBox comboRoleTyper;
        private System.Windows.Forms.DataGridViewLinkColumn Add_Goals;
    }
}