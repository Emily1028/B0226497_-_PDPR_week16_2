
namespace B0226497_段昱如_PDPR_week16_2
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSHOW = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.cash = new System.Windows.Forms.RadioButton();
            this.produce = new System.Windows.Forms.CheckedListBox();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.atm = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "B0226497_段昱如_PDPR_week16_2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "產品：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "送貨日期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "付款樣式：";
            // 
            // lblSHOW
            // 
            this.lblSHOW.AutoSize = true;
            this.lblSHOW.Location = new System.Drawing.Point(73, 570);
            this.lblSHOW.Name = "lblSHOW";
            this.lblSHOW.Size = new System.Drawing.Size(99, 24);
            this.lblSHOW.TabIndex = 0;
            this.lblSHOW.Text = "lblSHOW";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "段昱如";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(77, 513);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(126, 40);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "確定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.Location = new System.Drawing.Point(305, 187);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(127, 28);
            this.cash.TabIndex = 3;
            this.cash.TabStop = true;
            this.cash.Text = "貨到付款";
            this.cash.UseVisualStyleBackColor = true;
            this.cash.CheckedChanged += new System.EventHandler(this.cash_CheckedChanged);
            // 
            // produce
            // 
            this.produce.FormattingEnabled = true;
            this.produce.Items.AddRange(new object[] {
            "XBox 360",
            "PSP",
            "PS 2",
            "Game Boy",
            "任天堂",
            "SEGA"});
            this.produce.Location = new System.Drawing.Point(77, 170);
            this.produce.Name = "produce";
            this.produce.Size = new System.Drawing.Size(212, 274);
            this.produce.TabIndex = 4;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(209, 459);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(200, 35);
            this.time.TabIndex = 5;
            // 
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(260, 513);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(126, 40);
            this.btnEXIT.TabIndex = 2;
            this.btnEXIT.Text = "結束";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // atm
            // 
            this.atm.AutoSize = true;
            this.atm.Location = new System.Drawing.Point(305, 244);
            this.atm.Name = "atm";
            this.atm.Size = new System.Drawing.Size(81, 28);
            this.atm.TabIndex = 3;
            this.atm.TabStop = true;
            this.atm.Text = "ATM";
            this.atm.UseVisualStyleBackColor = true;
            this.atm.CheckedChanged += new System.EventHandler(this.atm_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 686);
            this.Controls.Add(this.time);
            this.Controls.Add(this.produce);
            this.Controls.Add(this.atm);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSHOW);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "B0226497_段昱如_PDPR_week16_2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSHOW;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton cash;
        private System.Windows.Forms.CheckedListBox produce;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.RadioButton atm;
    }
}

