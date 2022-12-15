namespace WinFormsHW
{
    partial class Form2
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
            this.avatar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.l_unread = new System.Windows.Forms.Label();
            this.l_rating = new System.Windows.Forms.Label();
            this.l_friends = new System.Windows.Forms.Label();
            this.l_email = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.SystemColors.Highlight;
            this.avatar.Location = new System.Drawing.Point(12, 12);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(150, 150);
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Друзья";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Рейтинг";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Непрочитанные:";
            // 
            // l_unread
            // 
            this.l_unread.AutoSize = true;
            this.l_unread.Location = new System.Drawing.Point(337, 154);
            this.l_unread.Name = "l_unread";
            this.l_unread.Size = new System.Drawing.Size(38, 15);
            this.l_unread.TabIndex = 1;
            this.l_unread.Text = "label1";
            // 
            // l_rating
            // 
            this.l_rating.AutoSize = true;
            this.l_rating.Location = new System.Drawing.Point(228, 102);
            this.l_rating.Name = "l_rating";
            this.l_rating.Size = new System.Drawing.Size(38, 15);
            this.l_rating.TabIndex = 1;
            this.l_rating.Text = "label1";
            // 
            // l_friends
            // 
            this.l_friends.AutoSize = true;
            this.l_friends.Location = new System.Drawing.Point(228, 72);
            this.l_friends.Name = "l_friends";
            this.l_friends.Size = new System.Drawing.Size(38, 15);
            this.l_friends.TabIndex = 1;
            this.l_friends.Text = "label1";
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.Location = new System.Drawing.Point(228, 42);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(38, 15);
            this.l_email.TabIndex = 1;
            this.l_email.Text = "label1";
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(228, 12);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(38, 15);
            this.l_name.TabIndex = 1;
            this.l_name.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 178);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.l_email);
            this.Controls.Add(this.l_friends);
            this.Controls.Add(this.l_rating);
            this.Controls.Add(this.l_unread);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Профиль";
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox avatar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label l_unread;
        private Label l_rating;
        private Label l_friends;
        private Label l_email;
        private Label l_name;
    }
}