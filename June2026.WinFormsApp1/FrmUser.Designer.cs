namespace June2026.WinFormsApp1
{
    partial class FrmUser
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
            dgvData = new DataGridView();
            ColEdit = new DataGridViewButtonColumn();
            ColDelete = new DataGridViewButtonColumn();
            ColRowNo = new DataGridViewTextBoxColumn();
            ColUserId = new DataGridViewTextBoxColumn();
            ColUsername = new DataGridViewTextBoxColumn();
            ColPassword = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtUsername = new TextBox();
            btnSave = new Button();
            label2 = new Label();
            txtPassword = new TextBox();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { ColEdit, ColDelete, ColRowNo, ColUserId, ColUsername, ColPassword });
            dgvData.Dock = DockStyle.Bottom;
            dgvData.Location = new Point(0, 262);
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(800, 188);
            dgvData.TabIndex = 7;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // ColEdit
            // 
            ColEdit.HeaderText = "Edit";
            ColEdit.MinimumWidth = 6;
            ColEdit.Name = "ColEdit";
            ColEdit.ReadOnly = true;
            ColEdit.Text = "Edit";
            ColEdit.UseColumnTextForButtonValue = true;
            // 
            // ColDelete
            // 
            ColDelete.HeaderText = "Delete";
            ColDelete.MinimumWidth = 6;
            ColDelete.Name = "ColDelete";
            ColDelete.ReadOnly = true;
            ColDelete.Text = "Delete";
            ColDelete.UseColumnTextForButtonValue = true;
            // 
            // ColRowNo
            // 
            ColRowNo.DataPropertyName = "RowNo";
            ColRowNo.HeaderText = "Row No.";
            ColRowNo.MinimumWidth = 6;
            ColRowNo.Name = "ColRowNo";
            ColRowNo.ReadOnly = true;
            // 
            // ColUserId
            // 
            ColUserId.DataPropertyName = "UserId";
            ColUserId.HeaderText = "User Id";
            ColUserId.MinimumWidth = 6;
            ColUserId.Name = "ColUserId";
            ColUserId.ReadOnly = true;
            // 
            // ColUsername
            // 
            ColUsername.DataPropertyName = "Username";
            ColUsername.HeaderText = "Username";
            ColUsername.MinimumWidth = 6;
            ColUsername.Name = "ColUsername";
            ColUsername.ReadOnly = true;
            // 
            // ColPassword
            // 
            ColPassword.DataPropertyName = "Password";
            ColPassword.HeaderText = "Password";
            ColPassword.MinimumWidth = 6;
            ColPassword.Name = "ColPassword";
            ColPassword.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 53);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(225, 53);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(195, 27);
            txtUsername.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(326, 154);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 113);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(225, 106);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(195, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(225, 154);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FrmUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(dgvData);
            Name = "FrmUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUser";
            Load += FrmUser_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvData;
        private Label label1;
        private TextBox txtUsername;
        private Button btnSave;
        private Label label2;
        private TextBox txtPassword;
        private Button btnCancel;
        private DataGridViewButtonColumn ColEdit;
        private DataGridViewButtonColumn ColDelete;
        private DataGridViewTextBoxColumn ColRowNo;
        private DataGridViewTextBoxColumn ColUserId;
        private DataGridViewTextBoxColumn ColUsername;
        private DataGridViewTextBoxColumn ColPassword;
    }
}
