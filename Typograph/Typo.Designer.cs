namespace Typograph
{
    partial class Typo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Typo));
            this.unverified = new System.Windows.Forms.RichTextBox();
            this.verified = new System.Windows.Forms.RichTextBox();
            this.print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unverified
            // 
            this.unverified.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.unverified.Location = new System.Drawing.Point(12, 12);
            this.unverified.Name = "unverified";
            this.unverified.Size = new System.Drawing.Size(643, 900);
            this.unverified.TabIndex = 0;
            this.unverified.Text = "";
            // 
            // verified
            // 
            this.verified.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.verified.Location = new System.Drawing.Point(676, 12);
            this.verified.Name = "verified";
            this.verified.Size = new System.Drawing.Size(664, 900);
            this.verified.TabIndex = 1;
            this.verified.Text = "";
            // 
            // print
            // 
            this.print.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print.Location = new System.Drawing.Point(551, 918);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(263, 51);
            this.print.TabIndex = 2;
            this.print.Text = "Оттипографировать";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // Typo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1401, 1078);
            this.Controls.Add(this.print);
            this.Controls.Add(this.verified);
            this.Controls.Add(this.unverified);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Typo";
            this.Text = "Типограф";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox unverified;
        private System.Windows.Forms.RichTextBox verified;
        private System.Windows.Forms.Button print;
    }
}

