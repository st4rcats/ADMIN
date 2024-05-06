namespace ACT1A_CRUD
{
    partial class Admin
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
            label1 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtUsername = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            cbRole = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnLagout = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(128, 111);
            label1.Name = "label1";
            label1.Size = new Size(0, 85);
            label1.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.None;
            txtID.Location = new Point(39, 46);
            txtID.Name = "txtID";
            txtID.Size = new Size(182, 16);
            txtID.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(38, 93);
            txtName.Name = "txtName";
            txtName.Size = new Size(183, 16);
            txtName.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(39, 144);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(182, 16);
            txtUsername.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(39, 199);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(183, 16);
            textBox4.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 28);
            label2.Name = "label2";
            label2.Size = new Size(20, 16);
            label2.TabIndex = 5;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 75);
            label3.Name = "label3";
            label3.Size = new Size(43, 16);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 126);
            label4.Name = "label4";
            label4.Size = new Size(68, 16);
            label4.TabIndex = 7;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(43, 181);
            label5.Name = "label5";
            label5.Size = new Size(65, 16);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(38, 252);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 23);
            comboBox1.TabIndex = 9;
            // 
            // cbRole
            // 
            cbRole.AutoSize = true;
            cbRole.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbRole.Location = new Point(50, 234);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(34, 16);
            cbRole.TabIndex = 10;
            cbRole.Text = "Role";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LawnGreen;
            btnAdd.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(39, 304);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(180, 36);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add Account";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DodgerBlue;
            btnUpdate.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(42, 360);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(181, 36);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update Account";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(43, 413);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(178, 32);
            btnRemove.TabIndex = 13;
            btnRemove.Text = "Remove Account";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnLagout
            // 
            btnLagout.BackColor = Color.Red;
            btnLagout.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLagout.Location = new Point(43, 456);
            btnLagout.Name = "btnLagout";
            btnLagout.Size = new Size(180, 33);
            btnLagout.TabIndex = 14;
            btnLagout.Text = "Lagout";
            btnLagout.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Location = new Point(309, 93);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(171, 16);
            txtSearch.TabIndex = 15;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Chartreuse;
            btnSearch.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(486, 92);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(92, 23);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(309, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(348, 345);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(42, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 3);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Location = new Point(42, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 3);
            panel2.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Location = new Point(43, 212);
            panel3.Name = "panel3";
            panel3.Size = new Size(181, 3);
            panel3.TabIndex = 20;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.HotTrack;
            panel4.Location = new Point(38, 272);
            panel4.Name = "panel4";
            panel4.Size = new Size(183, 3);
            panel4.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.HotTrack;
            panel5.Location = new Point(43, 157);
            panel5.Name = "panel5";
            panel5.Size = new Size(180, 3);
            panel5.TabIndex = 22;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.HotTrack;
            panel6.Location = new Point(309, 106);
            panel6.Name = "panel6";
            panel6.Size = new Size(171, 3);
            panel6.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(359, 15);
            label6.Name = "label6";
            label6.Size = new Size(121, 32);
            label6.TabIndex = 24;
            label6.Text = "Welcome";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 591);
            Controls.Add(label6);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnLagout);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cbRole);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(txtUsername);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtUsername;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Label cbRole;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnLagout;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label6;
    }
}