namespace Example01
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.cashLabel1 = new System.Windows.Forms.Label();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.cashLabel2 = new System.Windows.Forms.Label();
            this.givebutton1 = new System.Windows.Forms.Button();
            this.givebutton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel1
            // 
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameLabel1.Location = new System.Drawing.Point(12, 22);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(133, 27);
            this.nameLabel1.TabIndex = 0;
            this.nameLabel1.Text = "nameLabel1";
            // 
            // cashLabel1
            // 
            this.cashLabel1.AutoSize = true;
            this.cashLabel1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cashLabel1.Location = new System.Drawing.Point(12, 73);
            this.cashLabel1.Name = "cashLabel1";
            this.cashLabel1.Size = new System.Drawing.Size(122, 27);
            this.cashLabel1.TabIndex = 1;
            this.cashLabel1.Text = "cashLabel1";
            // 
            // nameLabel2
            // 
            this.nameLabel2.AutoSize = true;
            this.nameLabel2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameLabel2.Location = new System.Drawing.Point(156, 22);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(133, 27);
            this.nameLabel2.TabIndex = 2;
            this.nameLabel2.Text = "nameLabel2";
            // 
            // cashLabel2
            // 
            this.cashLabel2.AutoSize = true;
            this.cashLabel2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cashLabel2.Location = new System.Drawing.Point(156, 73);
            this.cashLabel2.Name = "cashLabel2";
            this.cashLabel2.Size = new System.Drawing.Size(122, 27);
            this.cashLabel2.TabIndex = 3;
            this.cashLabel2.Text = "cashLabel2";
            // 
            // givebutton1
            // 
            this.givebutton1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.givebutton1.Location = new System.Drawing.Point(47, 130);
            this.givebutton1.Name = "givebutton1";
            this.givebutton1.Size = new System.Drawing.Size(204, 51);
            this.givebutton1.TabIndex = 4;
            this.givebutton1.Text = "Joe給Bob 100元";
            this.givebutton1.UseVisualStyleBackColor = true;
            this.givebutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // givebutton2
            // 
            this.givebutton2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.givebutton2.Location = new System.Drawing.Point(47, 187);
            this.givebutton2.Name = "givebutton2";
            this.givebutton2.Size = new System.Drawing.Size(204, 56);
            this.givebutton2.TabIndex = 5;
            this.givebutton2.Text = "Bob給Joe 250元";
            this.givebutton2.UseVisualStyleBackColor = true;
            this.givebutton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 262);
            this.Controls.Add(this.givebutton2);
            this.Controls.Add(this.givebutton1);
            this.Controls.Add(this.cashLabel2);
            this.Controls.Add(this.nameLabel2);
            this.Controls.Add(this.cashLabel1);
            this.Controls.Add(this.nameLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label cashLabel1;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.Label cashLabel2;
        private System.Windows.Forms.Button givebutton1;
        private System.Windows.Forms.Button givebutton2;
    }
}

