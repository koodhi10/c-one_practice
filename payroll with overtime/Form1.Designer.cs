namespace payroll_with_overtime
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
            this.txthourlypayrate = new System.Windows.Forms.TextBox();
            this.txthoursworker = new System.Windows.Forms.TextBox();
            this.lbltest2 = new System.Windows.Forms.Label();
            this.lblscore1 = new System.Windows.Forms.Label();
            this.lblgrosspayresult = new System.Windows.Forms.Label();
            this.lblgrosspay = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txthourlypayrate
            // 
            this.txthourlypayrate.BackColor = System.Drawing.SystemColors.Info;
            this.txthourlypayrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthourlypayrate.Location = new System.Drawing.Point(339, 203);
            this.txthourlypayrate.Name = "txthourlypayrate";
            this.txthourlypayrate.Size = new System.Drawing.Size(396, 34);
            this.txthourlypayrate.TabIndex = 26;
            this.txthourlypayrate.TextChanged += new System.EventHandler(this.txthourlypayrate_TextChanged);
            // 
            // txthoursworker
            // 
            this.txthoursworker.BackColor = System.Drawing.SystemColors.Info;
            this.txthoursworker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoursworker.Location = new System.Drawing.Point(339, 142);
            this.txthoursworker.Name = "txthoursworker";
            this.txthoursworker.Size = new System.Drawing.Size(396, 34);
            this.txthoursworker.TabIndex = 25;
            this.txthoursworker.TextChanged += new System.EventHandler(this.txthoursworker_TextChanged);
            // 
            // lbltest2
            // 
            this.lbltest2.AutoSize = true;
            this.lbltest2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltest2.Location = new System.Drawing.Point(115, 203);
            this.lbltest2.Name = "lbltest2";
            this.lbltest2.Size = new System.Drawing.Size(213, 32);
            this.lbltest2.TabIndex = 24;
            this.lbltest2.Text = "Hourly pay rate:";
            // 
            // lblscore1
            // 
            this.lblscore1.AutoSize = true;
            this.lblscore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore1.Location = new System.Drawing.Point(140, 142);
            this.lblscore1.Name = "lblscore1";
            this.lblscore1.Size = new System.Drawing.Size(188, 32);
            this.lblscore1.TabIndex = 23;
            this.lblscore1.Text = "Hours worker:";
            // 
            // lblgrosspayresult
            // 
            this.lblgrosspayresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblgrosspayresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrosspayresult.Location = new System.Drawing.Point(339, 308);
            this.lblgrosspayresult.Name = "lblgrosspayresult";
            this.lblgrosspayresult.Size = new System.Drawing.Size(396, 80);
            this.lblgrosspayresult.TabIndex = 28;
            this.lblgrosspayresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblgrosspayresult.Click += new System.EventHandler(this.lblgrosspayresult_Click);
            // 
            // lblgrosspay
            // 
            this.lblgrosspay.AutoSize = true;
            this.lblgrosspay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrosspay.Location = new System.Drawing.Point(185, 333);
            this.lblgrosspay.Name = "lblgrosspay";
            this.lblgrosspay.Size = new System.Drawing.Size(143, 32);
            this.lblgrosspay.TabIndex = 27;
            this.lblgrosspay.Text = "Grosspay:";
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(589, 418);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(146, 76);
            this.btnexit.TabIndex = 31;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(365, 418);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(146, 76);
            this.btnclear.TabIndex = 30;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(138, 418);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(184, 76);
            this.btncalculate.TabIndex = 29;
            this.btncalculate.Text = "Calculate Gross Pay";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 596);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lblgrosspayresult);
            this.Controls.Add(this.lblgrosspay);
            this.Controls.Add(this.txthourlypayrate);
            this.Controls.Add(this.txthoursworker);
            this.Controls.Add(this.lbltest2);
            this.Controls.Add(this.lblscore1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txthourlypayrate;
        private System.Windows.Forms.TextBox txthoursworker;
        private System.Windows.Forms.Label lbltest2;
        private System.Windows.Forms.Label lblscore1;
        private System.Windows.Forms.Label lblgrosspayresult;
        private System.Windows.Forms.Label lblgrosspay;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncalculate;
    }
}

