
namespace Redmine
{
    partial class СreateIssue
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
            this.comboBoxТрекер = new System.Windows.Forms.ComboBox();
            this.textBoxОписание = new System.Windows.Forms.TextBox();
            this.comboBoxПроект = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxТрекер
            // 
            this.comboBoxТрекер.FormattingEnabled = true;
            this.comboBoxТрекер.Location = new System.Drawing.Point(45, 110);
            this.comboBoxТрекер.Name = "comboBoxТрекер";
            this.comboBoxТрекер.Size = new System.Drawing.Size(121, 21);
            this.comboBoxТрекер.TabIndex = 0;
            // 
            // textBoxОписание
            // 
            this.textBoxОписание.Location = new System.Drawing.Point(45, 162);
            this.textBoxОписание.Name = "textBoxОписание";
            this.textBoxОписание.Size = new System.Drawing.Size(100, 20);
            this.textBoxОписание.TabIndex = 1;
            // 
            // comboBoxПроект
            // 
            this.comboBoxПроект.FormattingEnabled = true;
            this.comboBoxПроект.Location = new System.Drawing.Point(45, 67);
            this.comboBoxПроект.Name = "comboBoxПроект";
            this.comboBoxПроект.Size = new System.Drawing.Size(121, 21);
            this.comboBoxПроект.TabIndex = 2;
            // 
            // СreateIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxПроект);
            this.Controls.Add(this.textBoxОписание);
            this.Controls.Add(this.comboBoxТрекер);
            this.Name = "СreateIssue";
            this.Text = "СreateIssue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxТрекер;
        private System.Windows.Forms.TextBox textBoxОписание;
        private System.Windows.Forms.ComboBox comboBoxПроект;
    }
}