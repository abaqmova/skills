namespace MyCompany.StudAbakumova
{
    partial class NumericScan
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
            this.btnLeft = new MyCompany.StudAbakumova.ArrowButton(this.components);
            this.btnRight = new MyCompany.StudAbakumova.ArrowButton(this.components);
            this.txtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(139, 164);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.ScrollButton = System.Windows.Forms.ScrollButton.Left;
            this.btnLeft.Size = new System.Drawing.Size(100, 28);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "arrowButton1";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.ButtonOnClick);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(305, 164);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRight.Name = "btnRight";
            this.btnRight.ScrollButton = System.Windows.Forms.ScrollButton.Right;
            this.btnRight.Size = new System.Drawing.Size(100, 28);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = "arrowButton2";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.ButtonOnClick);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(215, 99);
            this.txtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(132, 22);
            this.txtBox.TabIndex = 2;
            this.txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBox.TextChanged += new System.EventHandler(this.TextBoxOnTextChanged);
            this.txtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxOnKeyDown);
            // 
            // NumericScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NumericScan";
            this.Size = new System.Drawing.Size(680, 373);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ArrowButton btnLeft;
        private ArrowButton btnRight;
        private System.Windows.Forms.TextBox txtBox;
    }
}