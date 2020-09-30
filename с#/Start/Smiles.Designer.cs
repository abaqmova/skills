namespace WindowsFormsApp3
{
    partial class Smiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Smiles));
            this.picHappy = new System.Windows.Forms.PictureBox();
            this.picFrown = new System.Windows.Forms.PictureBox();
            this.picSmile = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmile)).BeginInit();
            this.SuspendLayout();
            // 
            // piсHappy
            // 
            this.picHappy.Image = ((System.Drawing.Image)(resources.GetObject("piсHappy.Image")));
            this.picHappy.Location = new System.Drawing.Point(176, 73);
            this.picHappy.Margin = new System.Windows.Forms.Padding(4);
            this.picHappy.Name = "piсHappy";
            this.picHappy.Size = new System.Drawing.Size(148, 123);
            this.picHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHappy.TabIndex = 0;
            this.picHappy.TabStop = false;
            this.picHappy.Click += new System.EventHandler(this.picHappy_Click);
            // 
            // picFrown
            // 
            this.picFrown.Image = ((System.Drawing.Image)(resources.GetObject("picFrown.Image")));
            this.picFrown.Location = new System.Drawing.Point(349, 73);
            this.picFrown.Margin = new System.Windows.Forms.Padding(4);
            this.picFrown.Name = "picFrown";
            this.picFrown.Size = new System.Drawing.Size(149, 123);
            this.picFrown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFrown.TabIndex = 1;
            this.picFrown.TabStop = false;
            this.picFrown.Click += new System.EventHandler(this.picFrown_Click);
            // 
            // picSmile
            // 
            this.picSmile.Image = ((System.Drawing.Image)(resources.GetObject("picSmile.Image")));
            this.picSmile.Location = new System.Drawing.Point(521, 73);
            this.picSmile.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.picSmile.Name = "picSmile";
            this.picSmile.Size = new System.Drawing.Size(153, 123);
            this.picSmile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSmile.TabIndex = 2;
            this.picSmile.TabStop = false;
            this.picSmile.Click += new System.EventHandler(this.picSmile_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(176, 214);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(499, 50);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Жми на смайлы";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(361, 288);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Smiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.picSmile);
            this.Controls.Add(this.picFrown);
            this.Controls.Add(this.picHappy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Smiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Smiles";
            this.Load += new System.EventHandler(this.Smiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHappy;
        private System.Windows.Forms.PictureBox picFrown;
        private System.Windows.Forms.PictureBox picSmile;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnExit;
    }
}