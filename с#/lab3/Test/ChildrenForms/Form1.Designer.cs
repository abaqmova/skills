namespace MyCompany.StudAbakumova
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
            this.components = new System.ComponentModel.Container();
            this.btnClickGen = new MyCompany.StudAbakumova.ClickmaticButton(this.components);
            this.lblTickCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClickGen
            // 
            this.btnClickGen.Location = new System.Drawing.Point(395, 165);
            this.btnClickGen.Name = "btnClickGen";
            this.btnClickGen.Size = new System.Drawing.Size(75, 23);
            this.btnClickGen.TabIndex = 0;
            this.btnClickGen.Text = "ClickGen";
            this.btnClickGen.UseVisualStyleBackColor = true;
            this.btnClickGen.Click += new System.EventHandler(this.btnClickGen_Click);
            // 
            // lblTickCount
            // 
            this.lblTickCount.AutoSize = true;
            this.lblTickCount.Location = new System.Drawing.Point(361, 132);
            this.lblTickCount.Name = "lblTickCount";
            this.lblTickCount.Size = new System.Drawing.Size(35, 13);
            this.lblTickCount.TabIndex = 1;
            this.lblTickCount.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Simple";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClickGen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTickCount);
            this.Controls.Add(this.btnClickGen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClickmaticButton btnClickGen;
        private System.Windows.Forms.Label lblTickCount;
        private System.Windows.Forms.Button button1;
    }
}