namespace Customer_CRUD
{
    partial class CustomerForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewButtonClick = new System.Windows.Forms.Button();
            this.SaveButtonClick = new System.Windows.Forms.Button();
            this.UpdateButtonClick = new System.Windows.Forms.Button();
            this.DeleteButtonClick = new System.Windows.Forms.Button();
            this.JumpToFirstButtonClick = new System.Windows.Forms.Button();
            this.PreviousButtonClick = new System.Windows.Forms.Button();
            this.NextButtonClick = new System.Windows.Forms.Button();
            this.JumpToLastButtonClick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(153, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(483, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "Customer CRUD Operation";
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Location = new System.Drawing.Point(306, 121);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(345, 22);
            this.CustomerIDTextBox.TabIndex = 9;
            this.CustomerIDTextBox.TextChanged += new System.EventHandler(this.CustomerIDTextBox_TextChanged);
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(306, 186);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(345, 22);
            this.CustomerNameTextBox.TabIndex = 10;
            this.CustomerNameTextBox.TextChanged += new System.EventHandler(this.CustomerNameTextBox_TextChanged);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(306, 253);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(345, 22);
            this.CityTextBox.TabIndex = 11;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "City";
            // 
            // NewButtonClick
            // 
            this.NewButtonClick.Location = new System.Drawing.Point(65, 399);
            this.NewButtonClick.Name = "NewButtonClick";
            this.NewButtonClick.Size = new System.Drawing.Size(75, 23);
            this.NewButtonClick.TabIndex = 16;
            this.NewButtonClick.Text = "New";
            this.NewButtonClick.UseVisualStyleBackColor = true;
            this.NewButtonClick.Click += new System.EventHandler(this.NewButtonClick_Click);
            // 
            // SaveButtonClick
            // 
            this.SaveButtonClick.Location = new System.Drawing.Point(225, 399);
            this.SaveButtonClick.Name = "SaveButtonClick";
            this.SaveButtonClick.Size = new System.Drawing.Size(75, 23);
            this.SaveButtonClick.TabIndex = 17;
            this.SaveButtonClick.Text = "Save";
            this.SaveButtonClick.UseVisualStyleBackColor = true;
            this.SaveButtonClick.Click += new System.EventHandler(this.button7_Click);
            // 
            // UpdateButtonClick
            // 
            this.UpdateButtonClick.Location = new System.Drawing.Point(464, 399);
            this.UpdateButtonClick.Name = "UpdateButtonClick";
            this.UpdateButtonClick.Size = new System.Drawing.Size(75, 23);
            this.UpdateButtonClick.TabIndex = 18;
            this.UpdateButtonClick.Text = "Update";
            this.UpdateButtonClick.UseVisualStyleBackColor = true;
            this.UpdateButtonClick.Click += new System.EventHandler(this.UpdateButtonClick_Click);
            // 
            // DeleteButtonClick
            // 
            this.DeleteButtonClick.Location = new System.Drawing.Point(620, 399);
            this.DeleteButtonClick.Name = "DeleteButtonClick";
            this.DeleteButtonClick.Size = new System.Drawing.Size(75, 23);
            this.DeleteButtonClick.TabIndex = 19;
            this.DeleteButtonClick.Text = "Delete";
            this.DeleteButtonClick.UseVisualStyleBackColor = true;
            this.DeleteButtonClick.Click += new System.EventHandler(this.DeleteButtonClick_Click);
            // 
            // JumpToFirstButtonClick
            // 
            this.JumpToFirstButtonClick.Location = new System.Drawing.Point(65, 338);
            this.JumpToFirstButtonClick.Name = "JumpToFirstButtonClick";
            this.JumpToFirstButtonClick.Size = new System.Drawing.Size(75, 23);
            this.JumpToFirstButtonClick.TabIndex = 20;
            this.JumpToFirstButtonClick.Text = "<<";
            this.JumpToFirstButtonClick.UseVisualStyleBackColor = true;
            this.JumpToFirstButtonClick.Click += new System.EventHandler(this.JumpToFirstButtonClick_Click);
            // 
            // PreviousButtonClick
            // 
            this.PreviousButtonClick.Location = new System.Drawing.Point(225, 338);
            this.PreviousButtonClick.Name = "PreviousButtonClick";
            this.PreviousButtonClick.Size = new System.Drawing.Size(75, 23);
            this.PreviousButtonClick.TabIndex = 21;
            this.PreviousButtonClick.Text = "<";
            this.PreviousButtonClick.UseVisualStyleBackColor = true;
            this.PreviousButtonClick.Click += new System.EventHandler(this.PreviousButtonClick_Click);
            // 
            // NextButtonClick
            // 
            this.NextButtonClick.Location = new System.Drawing.Point(464, 338);
            this.NextButtonClick.Name = "NextButtonClick";
            this.NextButtonClick.Size = new System.Drawing.Size(75, 23);
            this.NextButtonClick.TabIndex = 22;
            this.NextButtonClick.Text = ">";
            this.NextButtonClick.UseVisualStyleBackColor = true;
            this.NextButtonClick.Click += new System.EventHandler(this.NextButtonClick_Click);
            // 
            // JumpToLastButtonClick
            // 
            this.JumpToLastButtonClick.Location = new System.Drawing.Point(620, 338);
            this.JumpToLastButtonClick.Name = "JumpToLastButtonClick";
            this.JumpToLastButtonClick.Size = new System.Drawing.Size(75, 23);
            this.JumpToLastButtonClick.TabIndex = 23;
            this.JumpToLastButtonClick.Text = ">>";
            this.JumpToLastButtonClick.UseVisualStyleBackColor = true;
            this.JumpToLastButtonClick.Click += new System.EventHandler(this.JumpToLastButtonClick_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.JumpToLastButtonClick);
            this.Controls.Add(this.NextButtonClick);
            this.Controls.Add(this.PreviousButtonClick);
            this.Controls.Add(this.JumpToFirstButtonClick);
            this.Controls.Add(this.DeleteButtonClick);
            this.Controls.Add(this.UpdateButtonClick);
            this.Controls.Add(this.SaveButtonClick);
            this.Controls.Add(this.NewButtonClick);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.CustomerIDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustomerIDTextBox;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NewButtonClick;
        private System.Windows.Forms.Button SaveButtonClick;
        private System.Windows.Forms.Button UpdateButtonClick;
        private System.Windows.Forms.Button DeleteButtonClick;
        private System.Windows.Forms.Button JumpToFirstButtonClick;
        private System.Windows.Forms.Button PreviousButtonClick;
        private System.Windows.Forms.Button NextButtonClick;
        private System.Windows.Forms.Button JumpToLastButtonClick;
    }
}