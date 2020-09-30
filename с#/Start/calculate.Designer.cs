using System;

namespace WindowsFormsApp3
{
    partial class Calculate
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.btnDecrement = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.btnSquare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(98, 116);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(98, 17);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "первое число";
            this.lblFirst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFirst.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(99, 157);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(97, 17);
            this.lblSecond.TabIndex = 1;
            this.lblSecond.Text = "второе число";
            this.lblSecond.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(98, 269);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(75, 17);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "результат";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnIncrement
            // 
            this.btnIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIncrement.Location = new System.Drawing.Point(223, 203);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(40, 40);
            this.btnIncrement.TabIndex = 3;
            this.btnIncrement.Text = "+";
            this.btnIncrement.UseVisualStyleBackColor = true;
            this.btnIncrement.Click += new System.EventHandler(this.btn_Clik);
            // 
            // btnDecrement
            // 
            this.btnDecrement.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecrement.Location = new System.Drawing.Point(280, 203);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(40, 40);
            this.btnDecrement.TabIndex = 4;
            this.btnDecrement.Text = "-";
            this.btnDecrement.UseVisualStyleBackColor = true;
            this.btnDecrement.Click += new System.EventHandler(this.btn_Clik);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(206, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnIncrease
            // 
            this.btnIncrease.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIncrease.Location = new System.Drawing.Point(341, 203);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(40, 40);
            this.btnIncrease.TabIndex = 6;
            this.btnIncrease.Text = "*";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btn_Clik);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDivide.Location = new System.Drawing.Point(396, 203);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(40, 40);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = ":";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btn_Clik);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(237, 269);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(199, 22);
            this.txtResult.TabIndex = 8;
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(237, 111);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(199, 22);
            this.txtSecond.TabIndex = 9;
            this.txtSecond.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFirst_KeyDown);
            this.txtSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFirst_KeyPress);
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(237, 152);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(199, 22);
            this.txtFirst.TabIndex = 10;
            this.txtFirst.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            this.txtFirst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFirst_KeyDown);
            this.txtFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFirst_KeyPress);
            // 
            // btnSquare
            // 
            this.btnSquare.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSquare.Location = new System.Drawing.Point(456, 203);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(80, 40);
            this.btnSquare.TabIndex = 11;
            this.btnSquare.Text = "x2";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btn_Clik);
            // 
            // calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDecrement);
            this.Controls.Add(this.btnIncrement);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "calculate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "простой калькулятор";
            this.Load += new System.EventHandler(this.Calculate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Button btnDecrement;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Button btnSquare;
    }
}