namespace Range_checker
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
            this.Rangebox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtinteger = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblrangedecision = new System.Windows.Forms.Label();
            this.btncheck = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.Rangebox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rangebox
            // 
            this.Rangebox.Controls.Add(this.btnexit);
            this.Rangebox.Controls.Add(this.btnclear);
            this.Rangebox.Controls.Add(this.btncheck);
            this.Rangebox.Controls.Add(this.lblrangedecision);
            this.Rangebox.Controls.Add(this.label2);
            this.Rangebox.Controls.Add(this.txtinteger);
            this.Rangebox.Controls.Add(this.label1);
            this.Rangebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rangebox.Location = new System.Drawing.Point(67, 37);
            this.Rangebox.Name = "Rangebox";
            this.Rangebox.Size = new System.Drawing.Size(836, 426);
            this.Rangebox.TabIndex = 0;
            this.Rangebox.TabStop = false;
            this.Rangebox.Text = "Range Checker Application";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(730, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter an integer in the range of throught 10";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtinteger
            // 
            this.txtinteger.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinteger.Location = new System.Drawing.Point(159, 109);
            this.txtinteger.Name = "txtinteger";
            this.txtinteger.Size = new System.Drawing.Size(493, 41);
            this.txtinteger.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Range Decision";
            // 
            // lblrangedecision
            // 
            this.lblrangedecision.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblrangedecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblrangedecision.Location = new System.Drawing.Point(13, 236);
            this.lblrangedecision.Name = "lblrangedecision";
            this.lblrangedecision.Size = new System.Drawing.Size(723, 50);
            this.lblrangedecision.TabIndex = 3;
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(87, 314);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(183, 72);
            this.btncheck.TabIndex = 4;
            this.btncheck.Text = "Check \r\nQualfication";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(314, 314);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(183, 72);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(553, 314);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(183, 72);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 539);
            this.Controls.Add(this.Rangebox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Rangebox.ResumeLayout(false);
            this.Rangebox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Rangebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtinteger;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Label lblrangedecision;
        private System.Windows.Forms.Label label2;
    }
}

