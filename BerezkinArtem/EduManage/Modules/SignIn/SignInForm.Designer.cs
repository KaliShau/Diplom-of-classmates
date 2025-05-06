namespace EduManage.Modules.SignIn
{
    partial class SignInForm
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
            label1 = new Label();
            loginBox = new TextBox();
            label2 = new Label();
            passwordBox = new TextBox();
            label3 = new Label();
            signinButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(329, 32);
            label1.TabIndex = 1;
            label1.Text = "Введите логин и пароль";
            // 
            // loginBox
            // 
            loginBox.BorderStyle = BorderStyle.FixedSingle;
            loginBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBox.Location = new Point(302, 94);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(371, 32);
            loginBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(302, 70);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 3;
            label2.Text = "Логин";
            // 
            // passwordBox
            // 
            passwordBox.BorderStyle = BorderStyle.FixedSingle;
            passwordBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.Location = new Point(302, 169);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(371, 32);
            passwordBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(302, 145);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 3;
            label3.Text = "Пароль";
            // 
            // signinButton
            // 
            signinButton.BackColor = SystemColors.GradientActiveCaption;
            signinButton.FlatAppearance.BorderSize = 0;
            signinButton.FlatStyle = FlatStyle.Flat;
            signinButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signinButton.Location = new Point(373, 245);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(212, 39);
            signinButton.TabIndex = 4;
            signinButton.Text = "Войти";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += signinButton_Click;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1032, 690);
            Controls.Add(signinButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passwordBox);
            Controls.Add(loginBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignInForm";
            Text = "SignInForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox loginBox;
        private Label label2;
        private TextBox passwordBox;
        private Label label3;
        private Button signinButton;
    }
}