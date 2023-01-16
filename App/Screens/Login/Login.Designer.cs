namespace App.Screens.Login;

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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.ckbKeepSession = new MetroFramework.Controls.MetroCheckBox();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.lblPasswordValidation = new System.Windows.Forms.Label();
            this.lblRegistrationValidation = new System.Windows.Forms.Label();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRegistration = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroPanel1.Controls.Add(this.ckbKeepSession);
            this.metroPanel1.Controls.Add(this.lblLoginError);
            this.metroPanel1.Controls.Add(this.lblPasswordValidation);
            this.metroPanel1.Controls.Add(this.lblRegistrationValidation);
            this.metroPanel1.Controls.Add(this.btnLogin);
            this.metroPanel1.Controls.Add(this.txtPassword);
            this.metroPanel1.Controls.Add(this.txtRegistration);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(404, 322);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // ckbKeepSession
            // 
            this.ckbKeepSession.AutoSize = true;
            this.ckbKeepSession.Location = new System.Drawing.Point(236, 165);
            this.ckbKeepSession.Name = "ckbKeepSession";
            this.ckbKeepSession.Size = new System.Drawing.Size(107, 15);
            this.ckbKeepSession.TabIndex = 10;
            this.ckbKeepSession.Text = "Manter a sessão";
            this.ckbKeepSession.UseSelectable = true;
            // 
            // lblLoginError
            // 
            this.lblLoginError.AutoSize = true;
            this.lblLoginError.ForeColor = System.Drawing.Color.Red;
            this.lblLoginError.Location = new System.Drawing.Point(165, 40);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(75, 15);
            this.lblLoginError.TabIndex = 9;
            this.lblLoginError.Text = "lblLoginError";
            // 
            // lblPasswordValidation
            // 
            this.lblPasswordValidation.AutoSize = true;
            this.lblPasswordValidation.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordValidation.Location = new System.Drawing.Point(118, 121);
            this.lblPasswordValidation.Name = "lblPasswordValidation";
            this.lblPasswordValidation.Size = new System.Drawing.Size(122, 15);
            this.lblPasswordValidation.TabIndex = 8;
            this.lblPasswordValidation.Text = "lblPasswordValidation";
            // 
            // lblRegistrationValidation
            // 
            this.lblRegistrationValidation.AutoSize = true;
            this.lblRegistrationValidation.ForeColor = System.Drawing.Color.Red;
            this.lblRegistrationValidation.Location = new System.Drawing.Point(137, 73);
            this.lblRegistrationValidation.Name = "lblRegistrationValidation";
            this.lblRegistrationValidation.Size = new System.Drawing.Size(135, 15);
            this.lblRegistrationValidation.TabIndex = 7;
            this.lblRegistrationValidation.Text = "lblRegistrationValidation";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(152, 216);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(91, 52);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "ENTRAR";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(68, 139);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(275, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtRegistration
            // 
            this.txtRegistration.Location = new System.Drawing.Point(68, 91);
            this.txtRegistration.Name = "txtRegistration";
            this.txtRegistration.Size = new System.Drawing.Size(275, 23);
            this.txtRegistration.TabIndex = 4;
            this.txtRegistration.TextChanged += new System.EventHandler(this.txtRegistration_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(68, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Senha";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(68, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Matrícula";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 448);
            this.Controls.Add(this.metroPanel1);
            this.MinimumSize = new System.Drawing.Size(450, 448);
            this.Name = "Login";
            this.Text = "Entrada";
            this.Load += new System.EventHandler(this.Login_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private MetroFramework.Controls.MetroPanel metroPanel1;
    private MetroFramework.Controls.MetroLabel metroLabel1;
    private MetroFramework.Controls.MetroLabel metroLabel2;
    private TextBox txtRegistration;
    private TextBox txtPassword;
    private MetroFramework.Controls.MetroButton btnLogin;
    private Label lblRegistrationValidation;
    private Label lblPasswordValidation;
    private Label lblLoginError;
    private MetroFramework.Controls.MetroCheckBox ckbKeepSession;
}