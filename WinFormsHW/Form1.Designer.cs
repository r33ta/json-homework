namespace WinFormsHW
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
            this.textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.errorlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(96, 12);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(174, 23);
            this.textbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите имя:";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(195, 41);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "Войти";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.ForeColor = System.Drawing.Color.Firebrick;
            this.errorlabel.Location = new System.Drawing.Point(12, 45);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(0, 15);
            this.errorlabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 79);
            this.Controls.Add(this.errorlabel);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textbox;
        private Label label1;
        private Button btn;
        private Label errorlabel;
    }
}