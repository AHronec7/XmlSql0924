namespace XmlSql0924
{
    partial class Form1
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
            this.Datagridview = new System.Windows.Forms.DataGridView();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.FileXML = new System.Windows.Forms.OpenFileDialog();
            this.Firstnametextbox = new System.Windows.Forms.TextBox();
            this.socialtextbox = new System.Windows.Forms.TextBox();
            this.Lastnametextbox = new System.Windows.Forms.TextBox();
            this.Gendertextbox = new System.Windows.Forms.TextBox();
            this.Emailtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Datagridview
            // 
            this.Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagridview.Location = new System.Drawing.Point(372, 12);
            this.Datagridview.Name = "Datagridview";
            this.Datagridview.Size = new System.Drawing.Size(473, 302);
            this.Datagridview.TabIndex = 0;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(281, 12);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 31);
            this.LoadBtn.TabIndex = 8;
            this.LoadBtn.Text = "Load Grid";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // FileXML
            // 
            this.FileXML.FileName = "OpenFile";
            // 
            // Firstnametextbox
            // 
            this.Firstnametextbox.Location = new System.Drawing.Point(110, 23);
            this.Firstnametextbox.Name = "Firstnametextbox";
            this.Firstnametextbox.Size = new System.Drawing.Size(116, 20);
            this.Firstnametextbox.TabIndex = 1;
            // 
            // socialtextbox
            // 
            this.socialtextbox.Location = new System.Drawing.Point(110, 100);
            this.socialtextbox.Name = "socialtextbox";
            this.socialtextbox.Size = new System.Drawing.Size(116, 20);
            this.socialtextbox.TabIndex = 3;
            // 
            // Lastnametextbox
            // 
            this.Lastnametextbox.Location = new System.Drawing.Point(110, 62);
            this.Lastnametextbox.Name = "Lastnametextbox";
            this.Lastnametextbox.Size = new System.Drawing.Size(116, 20);
            this.Lastnametextbox.TabIndex = 2;
            // 
            // Gendertextbox
            // 
            this.Gendertextbox.Location = new System.Drawing.Point(110, 139);
            this.Gendertextbox.Name = "Gendertextbox";
            this.Gendertextbox.Size = new System.Drawing.Size(116, 20);
            this.Gendertextbox.TabIndex = 4;
            // 
            // Emailtextbox
            // 
            this.Emailtextbox.Location = new System.Drawing.Point(110, 177);
            this.Emailtextbox.Name = "Emailtextbox";
            this.Emailtextbox.Size = new System.Drawing.Size(116, 20);
            this.Emailtextbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "SSN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(272, 142);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 12;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(253, 266);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 13;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "If you want to delete a row: ";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.ForeColor = System.Drawing.Color.Crimson;
            this.DeleteBtn.Location = new System.Drawing.Point(40, 257);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 6;
            this.DeleteBtn.Text = "Delete ";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 326);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Emailtextbox);
            this.Controls.Add(this.Gendertextbox);
            this.Controls.Add(this.Lastnametextbox);
            this.Controls.Add(this.socialtextbox);
            this.Controls.Add(this.Firstnametextbox);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.Datagridview);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Datagridview;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.OpenFileDialog FileXML;
        private System.Windows.Forms.TextBox Firstnametextbox;
        private System.Windows.Forms.TextBox socialtextbox;
        private System.Windows.Forms.TextBox Lastnametextbox;
        private System.Windows.Forms.TextBox Gendertextbox;
        private System.Windows.Forms.TextBox Emailtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DeleteBtn;
    }
}

