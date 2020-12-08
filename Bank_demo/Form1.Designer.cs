namespace Bank_demo
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
            this.components = new System.ComponentModel.Container();
            this.TopTextLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.newAccButton = new System.Windows.Forms.Button();
            this.RemoveButtom = new System.Windows.Forms.Button();
            this.accountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.TransferLabel = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.transfer_2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopTextLabel
            // 
            this.TopTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopTextLabel.Location = new System.Drawing.Point(195, 32);
            this.TopTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TopTextLabel.Name = "TopTextLabel";
            this.TopTextLabel.Size = new System.Drawing.Size(254, 63);
            this.TopTextLabel.TabIndex = 0;
            this.TopTextLabel.Text = "Bankapplikation";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(70, 98);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 69);
            this.listBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 249);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newAccButton
            // 
            this.newAccButton.Location = new System.Drawing.Point(70, 177);
            this.newAccButton.Margin = new System.Windows.Forms.Padding(2);
            this.newAccButton.Name = "newAccButton";
            this.newAccButton.Size = new System.Drawing.Size(122, 31);
            this.newAccButton.TabIndex = 4;
            this.newAccButton.Text = "New Account";
            this.newAccButton.UseVisualStyleBackColor = true;
            this.newAccButton.Click += new System.EventHandler(this.newAccButton_Click);
            // 
            // RemoveButtom
            // 
            this.RemoveButtom.Location = new System.Drawing.Point(70, 213);
            this.RemoveButtom.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveButtom.Name = "RemoveButtom";
            this.RemoveButtom.Size = new System.Drawing.Size(122, 31);
            this.RemoveButtom.TabIndex = 5;
            this.RemoveButtom.Text = "Remove\r\n";
            this.RemoveButtom.UseVisualStyleBackColor = true;
            this.RemoveButtom.Click += new System.EventHandler(this.RemoveButtom_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 284);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Rename";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(201, 177);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "Deposit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(201, 213);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 31);
            this.button4.TabIndex = 8;
            this.button4.Text = "Withdraw";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TransferLabel
            // 
            this.TransferLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TransferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferLabel.Location = new System.Drawing.Point(181, 327);
            this.TransferLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TransferLabel.Name = "TransferLabel";
            this.TransferLabel.Size = new System.Drawing.Size(242, 31);
            this.TransferLabel.TabIndex = 12;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(413, 98);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(168, 69);
            this.listBox2.TabIndex = 13;
            this.listBox2.Visible = false;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // transfer_2
            // 
            this.transfer_2.Location = new System.Drawing.Point(201, 249);
            this.transfer_2.Margin = new System.Windows.Forms.Padding(2);
            this.transfer_2.Name = "transfer_2";
            this.transfer_2.Size = new System.Drawing.Size(122, 31);
            this.transfer_2.TabIndex = 14;
            this.transfer_2.Text = "TransferNew";
            this.transfer_2.UseVisualStyleBackColor = true;
            this.transfer_2.Click += new System.EventHandler(this.transfer_2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(451, 177);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(78, 31);
            this.button6.TabIndex = 15;
            this.button6.Text = "Send";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 428);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.transfer_2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.TransferLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RemoveButtom);
            this.Controls.Add(this.newAccButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TopTextLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TopTextLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button newAccButton;
        private System.Windows.Forms.Button RemoveButtom;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.BindingSource accountBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label TransferLabel;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button transfer_2;
        private System.Windows.Forms.Button button6;
    }
}

