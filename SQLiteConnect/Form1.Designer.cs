namespace SQLiteConnect
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Insert_btn = new Button();
            Update_btn = new Button();
            Del_btn = new Button();
            dataGridView1 = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            Name_txt = new TextBox();
            Id_txt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(181, 28);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 0;
            label1.Text = "SQLitte Database";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 94);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 134);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 2;
            label3.Text = "ID :";
            // 
            // Insert_btn
            // 
            Insert_btn.Location = new Point(25, 196);
            Insert_btn.Name = "Insert_btn";
            Insert_btn.Size = new Size(160, 37);
            Insert_btn.TabIndex = 3;
            Insert_btn.Text = "Insert";
            Insert_btn.UseVisualStyleBackColor = true;
            Insert_btn.Click += Insert_btn_Click;
            // 
            // Update_btn
            // 
            Update_btn.Location = new Point(25, 239);
            Update_btn.Name = "Update_btn";
            Update_btn.Size = new Size(160, 37);
            Update_btn.TabIndex = 4;
            Update_btn.Text = "Update";
            Update_btn.UseVisualStyleBackColor = true;
            Update_btn.Click += Update_btn_Click;
            // 
            // Del_btn
            // 
            Del_btn.Location = new Point(25, 282);
            Del_btn.Name = "Del_btn";
            Del_btn.Size = new Size(160, 37);
            Del_btn.TabIndex = 5;
            Del_btn.Text = "Delete";
            Del_btn.UseVisualStyleBackColor = true;
            Del_btn.Click += Del_btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, id });
            dataGridView1.Location = new Point(202, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(296, 228);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.Name = "name";
            name.Width = 150;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            // 
            // Name_txt
            // 
            Name_txt.Location = new Point(69, 91);
            Name_txt.Name = "Name_txt";
            Name_txt.Size = new Size(127, 23);
            Name_txt.TabIndex = 7;
            // 
            // Id_txt
            // 
            Id_txt.Location = new Point(69, 131);
            Id_txt.Name = "Id_txt";
            Id_txt.Size = new Size(127, 23);
            Id_txt.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 337);
            Controls.Add(Id_txt);
            Controls.Add(Name_txt);
            Controls.Add(dataGridView1);
            Controls.Add(Del_btn);
            Controls.Add(Update_btn);
            Controls.Add(Insert_btn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button Insert_btn;
        private Button Update_btn;
        private Button Del_btn;
        private DataGridView dataGridView1;
        private TextBox Name_txt;
        private TextBox Id_txt;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn id;
    }
}
