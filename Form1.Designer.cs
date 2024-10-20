namespace HamletViewerApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox textBoxHamlet;

        /// <summary>
        /// Освобождение ресурсов.
        /// </summary>
        /// <param name="disposing">true, если управляемые ресурсы должны быть удалены; иначе false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Инициализация компонентов формы.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadButton = new System.Windows.Forms.Button();
            this.textBoxHamlet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 12);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(150, 58);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Загрузить текст Гамлета";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // textBoxHamlet
            // 
            this.textBoxHamlet.Location = new System.Drawing.Point(12, 76);
            this.textBoxHamlet.Multiline = true;
            this.textBoxHamlet.Name = "textBoxHamlet";
            this.textBoxHamlet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHamlet.Size = new System.Drawing.Size(1044, 431);
            this.textBoxHamlet.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 519);
            this.Controls.Add(this.textBoxHamlet);
            this.Controls.Add(this.loadButton);
            this.Name = "Form1";
            this.Text = "Hamlet Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
