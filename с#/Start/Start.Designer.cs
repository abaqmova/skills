namespace WindowsFormsApp3
{
    partial class Start
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.generalList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // generalList
            // 
            this.generalList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalList.FormattingEnabled = true;
            this.generalList.ItemHeight = 16;
            this.generalList.Items.AddRange(new object[] {
            "1)простое диалоговое окно со смайликами",
            "2) калькулятор "});
            this.generalList.Location = new System.Drawing.Point(0, 0);
            this.generalList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generalList.Name = "generalList";
            this.generalList.Size = new System.Drawing.Size(379, 321);
            this.generalList.TabIndex = 0;
            this.generalList.SelectedIndexChanged += new System.EventHandler(this.generalList_SelectedIndexChanged);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.generalList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Абакумова София, АДБ1708";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox generalList;
    }
}

