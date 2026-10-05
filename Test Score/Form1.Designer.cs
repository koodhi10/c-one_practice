namespace Test_Score
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
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblaverageresult = new System.Windows.Forms.Label();
            this.lblavarage = new System.Windows.Forms.Label();
            this.txtscore3 = new System.Windows.Forms.TextBox();
            this.txtscore2 = new System.Windows.Forms.TextBox();
            this.txtscore1 = new System.Windows.Forms.TextBox();
            this.lblscore3 = new System.Windows.Forms.Label();
            this.lbltest2 = new System.Windows.Forms.Label();
            this.lblscore1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(246, 498);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(184, 118);
            this.btncalculate.TabIndex = 8;
            this.btncalculate.Text = "Calculate Average";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(477, 498);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(146, 50);
            this.btnclear.TabIndex = 18;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(477, 566);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(146, 50);
            this.btnexit.TabIndex = 19;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lblaverageresult);
            this.groupBox1.Controls.Add(this.lblavarage);
            this.groupBox1.Controls.Add(this.txtscore3);
            this.groupBox1.Controls.Add(this.txtscore2);
            this.groupBox1.Controls.Add(this.txtscore1);
            this.groupBox1.Controls.Add(this.lblscore3);
            this.groupBox1.Controls.Add(this.lbltest2);
            this.groupBox1.Controls.Add(this.lblscore1);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(86, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 420);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Three Test Scores";
            // 
            // lblaverageresult
            // 
            this.lblaverageresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblaverageresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaverageresult.Location = new System.Drawing.Point(273, 275);
            this.lblaverageresult.Name = "lblaverageresult";
            this.lblaverageresult.Size = new System.Drawing.Size(396, 80);
            this.lblaverageresult.TabIndex = 25;
            this.lblaverageresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblavarage
            // 
            this.lblavarage.AutoSize = true;
            this.lblavarage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavarage.Location = new System.Drawing.Point(119, 300);
            this.lblavarage.Name = "lblavarage";
            this.lblavarage.Size = new System.Drawing.Size(120, 32);
            this.lblavarage.TabIndex = 24;
            this.lblavarage.Text = "Average";
            // 
            // txtscore3
            // 
            this.txtscore3.BackColor = System.Drawing.SystemColors.Info;
            this.txtscore3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore3.Location = new System.Drawing.Point(273, 195);
            this.txtscore3.Name = "txtscore3";
            this.txtscore3.Size = new System.Drawing.Size(396, 34);
            this.txtscore3.TabIndex = 23;
            this.txtscore3.TextChanged += new System.EventHandler(this.txtscore3_TextChanged);
            // 
            // txtscore2
            // 
            this.txtscore2.BackColor = System.Drawing.SystemColors.Info;
            this.txtscore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore2.Location = new System.Drawing.Point(273, 143);
            this.txtscore2.Name = "txtscore2";
            this.txtscore2.Size = new System.Drawing.Size(396, 34);
            this.txtscore2.TabIndex = 22;
            this.txtscore2.TextChanged += new System.EventHandler(this.txtscore2_TextChanged);
            // 
            // txtscore1
            // 
            this.txtscore1.BackColor = System.Drawing.SystemColors.Info;
            this.txtscore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore1.Location = new System.Drawing.Point(273, 82);
            this.txtscore1.Name = "txtscore1";
            this.txtscore1.Size = new System.Drawing.Size(396, 34);
            this.txtscore1.TabIndex = 21;
            this.txtscore1.TextChanged += new System.EventHandler(this.txtscore1_TextChanged);
            // 
            // lblscore3
            // 
            this.lblscore3.AutoSize = true;
            this.lblscore3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore3.Location = new System.Drawing.Point(66, 197);
            this.lblscore3.Name = "lblscore3";
            this.lblscore3.Size = new System.Drawing.Size(173, 32);
            this.lblscore3.TabIndex = 20;
            this.lblscore3.Text = "Test Score 3";
            // 
            // lbltest2
            // 
            this.lbltest2.AutoSize = true;
            this.lbltest2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltest2.Location = new System.Drawing.Point(66, 143);
            this.lbltest2.Name = "lbltest2";
            this.lbltest2.Size = new System.Drawing.Size(173, 32);
            this.lbltest2.TabIndex = 19;
            this.lbltest2.Text = "Test Score 2";
            // 
            // lblscore1
            // 
            this.lblscore1.AutoSize = true;
            this.lblscore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore1.Location = new System.Drawing.Point(66, 82);
            this.lblscore1.Name = "lblscore1";
            this.lblscore1.Size = new System.Drawing.Size(173, 32);
            this.lblscore1.TabIndex = 18;
            this.lblscore1.Text = "Test Score 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(929, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblaverageresult;
        private System.Windows.Forms.Label lblavarage;
        private System.Windows.Forms.TextBox txtscore3;
        private System.Windows.Forms.TextBox txtscore2;
        private System.Windows.Forms.TextBox txtscore1;
        private System.Windows.Forms.Label lblscore3;
        private System.Windows.Forms.Label lbltest2;
        private System.Windows.Forms.Label lblscore1;
    }
}

