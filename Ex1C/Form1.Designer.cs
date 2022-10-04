
namespace Ex1C
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtAPickle = new System.Windows.Forms.TextBox();
            this.txtBagOfAir = new System.Windows.Forms.TextBox();
            this.txtAPickleSubtotal = new System.Windows.Forms.TextBox();
            this.txtBagOfAirSubtotal = new System.Windows.Forms.TextBox();
            this.txtPretaxTotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "A pickle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bag of air:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "x $20.00=";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "x $5.00=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pretax total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tax:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(35, 336);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(162, 336);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(291, 336);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtAPickle
            // 
            this.txtAPickle.Location = new System.Drawing.Point(114, 39);
            this.txtAPickle.Name = "txtAPickle";
            this.txtAPickle.Size = new System.Drawing.Size(54, 23);
            this.txtAPickle.TabIndex = 10;
            this.txtAPickle.Text = "0";
            this.txtAPickle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBagOfAir
            // 
            this.txtBagOfAir.Location = new System.Drawing.Point(114, 91);
            this.txtBagOfAir.Name = "txtBagOfAir";
            this.txtBagOfAir.Size = new System.Drawing.Size(54, 23);
            this.txtBagOfAir.TabIndex = 11;
            this.txtBagOfAir.Text = "0";
            this.txtBagOfAir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAPickleSubtotal
            // 
            this.txtAPickleSubtotal.Location = new System.Drawing.Point(237, 39);
            this.txtAPickleSubtotal.Name = "txtAPickleSubtotal";
            this.txtAPickleSubtotal.ReadOnly = true;
            this.txtAPickleSubtotal.Size = new System.Drawing.Size(100, 23);
            this.txtAPickleSubtotal.TabIndex = 12;
            // 
            // txtBagOfAirSubtotal
            // 
            this.txtBagOfAirSubtotal.Location = new System.Drawing.Point(237, 92);
            this.txtBagOfAirSubtotal.Name = "txtBagOfAirSubtotal";
            this.txtBagOfAirSubtotal.ReadOnly = true;
            this.txtBagOfAirSubtotal.Size = new System.Drawing.Size(100, 23);
            this.txtBagOfAirSubtotal.TabIndex = 13;
            // 
            // txtPretaxTotal
            // 
            this.txtPretaxTotal.Location = new System.Drawing.Point(238, 168);
            this.txtPretaxTotal.Name = "txtPretaxTotal";
            this.txtPretaxTotal.ReadOnly = true;
            this.txtPretaxTotal.Size = new System.Drawing.Size(100, 23);
            this.txtPretaxTotal.TabIndex = 14;
            this.txtPretaxTotal.TextChanged += new System.EventHandler(this.txtPretaxTotal_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(237, 268);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 15;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(237, 217);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 23);
            this.txtTax.TabIndex = 16;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 387);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPretaxTotal);
            this.Controls.Add(this.txtBagOfAirSubtotal);
            this.Controls.Add(this.txtAPickleSubtotal);
            this.Controls.Add(this.txtBagOfAir);
            this.Controls.Add(this.txtAPickle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Food Truck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtAPickle;
        private System.Windows.Forms.TextBox txtBagOfAir;
        private System.Windows.Forms.TextBox txtAPickleSubtotal;
        private System.Windows.Forms.TextBox txtBagOfAirSubtotal;
        private System.Windows.Forms.TextBox txtPretaxTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
    }
}

