namespace products
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
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.BTAddClient = new System.Windows.Forms.Button();
            this.BTView = new System.Windows.Forms.Button();
            this.DBGClient = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DBGProduct = new System.Windows.Forms.DataGridView();
            this.DBGSale = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DBGClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBGProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBGSale)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFirstname
            // 
            this.tbFirstname.Location = new System.Drawing.Point(103, 273);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(100, 22);
            this.tbFirstname.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Фамилия";
            // 
            // tbLastname
            // 
            this.tbLastname.Location = new System.Drawing.Point(295, 276);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(100, 22);
            this.tbLastname.TabIndex = 4;
            // 
            // BTAddClient
            // 
            this.BTAddClient.Location = new System.Drawing.Point(438, 270);
            this.BTAddClient.Name = "BTAddClient";
            this.BTAddClient.Size = new System.Drawing.Size(92, 28);
            this.BTAddClient.TabIndex = 5;
            this.BTAddClient.Text = "Добавить";
            this.BTAddClient.UseVisualStyleBackColor = true;
            this.BTAddClient.Click += new System.EventHandler(this.BTAddClient_Click);
            // 
            // BTView
            // 
            this.BTView.Location = new System.Drawing.Point(1226, 433);
            this.BTView.Name = "BTView";
            this.BTView.Size = new System.Drawing.Size(92, 28);
            this.BTView.TabIndex = 6;
            this.BTView.Text = "Показать";
            this.BTView.UseVisualStyleBackColor = true;
            this.BTView.Click += new System.EventHandler(this.BTView_Click);
            // 
            // DBGClient
            // 
            this.DBGClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGClient.Location = new System.Drawing.Point(30, 35);
            this.DBGClient.Name = "DBGClient";
            this.DBGClient.RowTemplate.Height = 24;
            this.DBGClient.Size = new System.Drawing.Size(552, 221);
            this.DBGClient.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1226, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Показать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(918, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Отобразить записи из таблицы Клиенты";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(918, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Отобразить записи из таблицы  Продукты";
            // 
            // DBGProduct
            // 
            this.DBGProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGProduct.Location = new System.Drawing.Point(707, 35);
            this.DBGProduct.Name = "DBGProduct";
            this.DBGProduct.RowTemplate.Height = 24;
            this.DBGProduct.Size = new System.Drawing.Size(462, 221);
            this.DBGProduct.TabIndex = 11;
            // 
            // DBGSale
            // 
            this.DBGSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGSale.Location = new System.Drawing.Point(30, 328);
            this.DBGSale.Name = "DBGSale";
            this.DBGSale.RowTemplate.Height = 24;
            this.DBGSale.Size = new System.Drawing.Size(668, 204);
            this.DBGSale.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1226, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 25);
            this.button2.TabIndex = 13;
            this.button2.Text = "Показать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(918, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Отобразить записи из таблицы Продажи";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 585);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DBGSale);
            this.Controls.Add(this.DBGProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DBGClient);
            this.Controls.Add(this.BTView);
            this.Controls.Add(this.BTAddClient);
            this.Controls.Add(this.tbLastname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFirstname);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DBGClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBGProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBGSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.Button BTAddClient;
        private System.Windows.Forms.Button BTView;
        private System.Windows.Forms.DataGridView DBGClient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DBGProduct;
        private System.Windows.Forms.DataGridView DBGSale;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}

