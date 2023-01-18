namespace App.Screens;

partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbKeepSession = new System.Windows.Forms.CheckBox();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.lblPasswordValidation = new System.Windows.Forms.Label();
            this.lblRegistrationValidation = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRegistration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.ckbKeepSession);
            this.panel1.Controls.Add(this.lblLoginError);
            this.panel1.Controls.Add(this.lblPasswordValidation);
            this.panel1.Controls.Add(this.lblRegistrationValidation);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtRegistration);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 322);
            this.panel1.TabIndex = 1;
            // 
            // ckbKeepSession
            // 
            this.ckbKeepSession.AutoSize = true;
            this.ckbKeepSession.Location = new System.Drawing.Point(236, 180);
            this.ckbKeepSession.Name = "ckbKeepSession";
            this.ckbKeepSession.Size = new System.Drawing.Size(110, 19);
            this.ckbKeepSession.TabIndex = 10;
            this.ckbKeepSession.Text = "Manter a sessão";
            // 
            // lblLoginError
            // 
            this.lblLoginError.AutoSize = true;
            this.lblLoginError.ForeColor = System.Drawing.Color.Red;
            this.lblLoginError.Location = new System.Drawing.Point(160, 39);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(75, 15);
            this.lblLoginError.TabIndex = 9;
            this.lblLoginError.Text = "lblLoginError";
            // 
            // lblPasswordValidation
            // 
            this.lblPasswordValidation.AutoSize = true;
            this.lblPasswordValidation.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordValidation.Location = new System.Drawing.Point(113, 132);
            this.lblPasswordValidation.Name = "lblPasswordValidation";
            this.lblPasswordValidation.Size = new System.Drawing.Size(122, 15);
            this.lblPasswordValidation.TabIndex = 8;
            this.lblPasswordValidation.Text = "lblPasswordValidation";
            // 
            // lblRegistrationValidation
            // 
            this.lblRegistrationValidation.AutoSize = true;
            this.lblRegistrationValidation.ForeColor = System.Drawing.Color.Red;
            this.lblRegistrationValidation.Location = new System.Drawing.Point(131, 84);
            this.lblRegistrationValidation.Name = "lblRegistrationValidation";
            this.lblRegistrationValidation.Size = new System.Drawing.Size(135, 15);
            this.lblRegistrationValidation.TabIndex = 7;
            this.lblRegistrationValidation.Text = "lblRegistrationValidation";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(152, 216);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(91, 52);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "ENTRAR";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(68, 150);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(275, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtRegistration
            // 
            this.txtRegistration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegistration.Location = new System.Drawing.Point(68, 104);
            this.txtRegistration.Name = "txtRegistration";
            this.txtRegistration.Size = new System.Drawing.Size(275, 23);
            this.txtRegistration.TabIndex = 4;
            this.txtRegistration.TextChanged += new System.EventHandler(this.txtRegistration_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matrícula";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(450, 450);
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private Panel panel1;
    private Label label1;
    private Label label2;
    private TextBox txtRegistration;
    private TextBox txtPassword;
    private Button btnLogin;
    private Label lblRegistrationValidation;
    private Label lblPasswordValidation;
    private Label lblLoginError;
    private CheckBox ckbKeepSession;
}