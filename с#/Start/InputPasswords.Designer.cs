using System;

namespace WindowsFormsApp3
{
    partial class InputPasswords
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
            this.flow = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.textInput = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.flow.SuspendLayout();
            this.SuspendLayout();
            // 
            // flow
            // 
            this.flow.AutoSize = true;
            this.flow.Controls.Add(this.lblMessage);
            this.flow.Controls.Add(this.textInput);
            this.flow.Controls.Add(this.btnOK);
            this.flow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flow.Location = new System.Drawing.Point(0, 0);
            this.flow.Margin = new System.Windows.Forms.Padding(4);
            this.flow.Name = "flow";
            this.flow.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.flow.Size = new System.Drawing.Size(1067, 554);
            this.flow.TabIndex = 0;
            this.flow.WrapContents = false;
            this.flow.Paint += new System.Windows.Forms.PaintEventHandler(this.flow_Paint);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(523, 20);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(46, 17);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "label1";
            // 
            // textInput
            // 
            this.textInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textInput.Location = new System.Drawing.Point(22, 57);
            this.textInput.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.textInput.Name = "textInput";
            this.textInput.PasswordChar = '*';
            this.textInput.Size = new System.Drawing.Size(1048, 22);
            this.textInput.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.AutoSize = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(496, 99);
            this.btnOK.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 33);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // InputPasswords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.flow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputPasswords";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.flow.ResumeLayout(false);
            this.flow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.FlowLayoutPanel flow;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Button btnOK;
        #endregion
    }
}
