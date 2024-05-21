namespace com.mercantilbanco.api.sample
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
            this.DecryptButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cvv = new System.Windows.Forms.TextBox();
            this.twofactor_type = new System.Windows.Forms.TextBox();
            this.twofactor_auth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.secretkey = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DecryptButton
            // 
            this.DecryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptButton.Location = new System.Drawing.Point(480, 180);
            this.DecryptButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(83, 26);
            this.DecryptButton.TabIndex = 5;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptButton.Location = new System.Drawing.Point(375, 180);
            this.EncryptButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(89, 26);
            this.EncryptButton.TabIndex = 4;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data to cypher or descypher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "CVV :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Two factor auth :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.secretkey);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cvv);
            this.panel1.Controls.Add(this.twofactor_type);
            this.panel1.Controls.Add(this.twofactor_auth);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(11, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 136);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Two factor type :";
            // 
            // cvv
            // 
            this.cvv.Location = new System.Drawing.Point(129, 36);
            this.cvv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cvv.Name = "cvv";
            this.cvv.Size = new System.Drawing.Size(409, 20);
            this.cvv.TabIndex = 1;
            // 
            // twofactor_type
            // 
            this.twofactor_type.Location = new System.Drawing.Point(129, 66);
            this.twofactor_type.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.twofactor_type.Name = "twofactor_type";
            this.twofactor_type.Size = new System.Drawing.Size(409, 20);
            this.twofactor_type.TabIndex = 2;
            // 
            // twofactor_auth
            // 
            this.twofactor_auth.Location = new System.Drawing.Point(130, 95);
            this.twofactor_auth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.twofactor_auth.Name = "twofactor_auth";
            this.twofactor_auth.Size = new System.Drawing.Size(409, 20);
            this.twofactor_auth.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Secret Key :";
            // 
            // secretkey
            // 
            this.secretkey.Location = new System.Drawing.Point(129, 5);
            this.secretkey.Margin = new System.Windows.Forms.Padding(2);
            this.secretkey.Name = "secretkey";
            this.secretkey.Size = new System.Drawing.Size(409, 20);
            this.secretkey.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 224);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.DecryptButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox twofactor_auth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cvv;
        private System.Windows.Forms.TextBox twofactor_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox secretkey;
    }
}

