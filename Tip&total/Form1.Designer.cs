namespace TIP_TAX_TOTAL
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
            this.Txtfood = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtfood2 = new System.Windows.Forms.TextBox();
            this.txtprice2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltotalsales = new System.Windows.Forms.Label();
            this.LBLINFO = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txtfood
            // 
            this.Txtfood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtfood.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtfood.Location = new System.Drawing.Point(368, 161);
            this.Txtfood.Name = "Txtfood";
            this.Txtfood.Size = new System.Drawing.Size(366, 34);
            this.Txtfood.TabIndex = 0;
            this.Txtfood.TextChanged += new System.EventHandler(this.Txtfood_TextChanged);
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(368, 229);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(366, 34);
            this.txtprice.TabIndex = 1;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // txtfood2
            // 
            this.txtfood2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfood2.Location = new System.Drawing.Point(368, 291);
            this.txtfood2.Name = "txtfood2";
            this.txtfood2.Size = new System.Drawing.Size(366, 34);
            this.txtfood2.TabIndex = 2;
            this.txtfood2.TextChanged += new System.EventHandler(this.txtfood2_TextChanged);
            // 
            // txtprice2
            // 
            this.txtprice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice2.Location = new System.Drawing.Point(368, 354);
            this.txtprice2.Name = "txtprice2";
            this.txtprice2.Size = new System.Drawing.Size(366, 34);
            this.txtprice2.TabIndex = 3;
            this.txtprice2.TextChanged += new System.EventHandler(this.txtprice2_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(70, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 106);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltotalsales
            // 
            this.lbltotalsales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotalsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalsales.Location = new System.Drawing.Point(636, 452);
            this.lbltotalsales.Name = "lbltotalsales";
            this.lbltotalsales.Size = new System.Drawing.Size(280, 45);
            this.lbltotalsales.TabIndex = 5;
            this.lbltotalsales.Click += new System.EventHandler(this.lbltotalsales_Click);
            // 
            // LBLINFO
            // 
            this.LBLINFO.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LBLINFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLINFO.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LBLINFO.Location = new System.Drawing.Point(279, 56);
            this.LBLINFO.Name = "LBLINFO";
            this.LBLINFO.Size = new System.Drawing.Size(389, 58);
            this.LBLINFO.TabIndex = 6;
            this.LBLINFO.Text = "TAX TOTAL ASSIGMENT";
            this.LBLINFO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltotal
            // 
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(636, 535);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(280, 45);
            this.lbltotal.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter The Price 1 :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter The Food 1 : ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 34);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter The Price 2 :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 34);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter The Food 2";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 34);
            this.label5.TabIndex = 13;
            this.label5.Text = "The Toatl is :";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 34);
            this.label6.TabIndex = 12;
            this.label6.Text = "The Sales Tax is :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 694);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.LBLINFO);
            this.Controls.Add(this.lbltotalsales);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtprice2);
            this.Controls.Add(this.txtfood2);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.Txtfood);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtfood;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtfood2;
        private System.Windows.Forms.TextBox txtprice2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbltotalsales;
        private System.Windows.Forms.Label LBLINFO;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

