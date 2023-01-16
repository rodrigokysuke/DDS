using App.EnDecryption;
using App.Models;
using App.Models.Entities;
using System.ComponentModel;
using Panel = App.Screens.Home;

namespace App.Screens.Login;

public partial class Login : MetroFramework.Forms.MetroForm
{
    private readonly DdsDbContext ddsDbContext;

    public Login()
    {
        InitializeComponent();

        this.ddsDbContext = new DdsDbContext();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        base.OnClosing(e);
    }

    private void Login_Load(object sender, EventArgs e)
    {
        CleanValidations();
        txtPassword.PasswordChar = '*';
        lblLoginError.Text = string.Empty;
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        if (!ComputeValidationErrors())
        {
            var employee = ddsDbContext.Employees.FirstOrDefault(e => e.Registration == txtRegistration.Text && e.Password == txtPassword.Text);
            if (employee != null)
            {
                ddsDbContext.Session.RemoveRange(ddsDbContext.Session);
                ddsDbContext.SaveChanges();

                if (ckbKeepSession.Checked)
                {
                    var key = Guid.NewGuid().ToString().Replace("-", string.Empty);
                    var passwordEncrypted = AesOperation.EncryptString(key, txtPassword.Text);

                    ddsDbContext.Session.Add(new Session
                    {
                        Registration = txtRegistration.Text,
                        PasswordEncrypted = passwordEncrypted,
                        PasswordDecryptionKey = key
                    });
                    ddsDbContext.SaveChanges();
                }

                var homeWindow = new Panel.Home();
                homeWindow.Show();
                this.Hide();
            }
            else lblLoginError.Text = "Matrícula e/ou senha incorretas.";
        }
    }

    private void txtRegistration_TextChanged(object sender, EventArgs e)
    {
        CleanValidations(true, false);

        if (string.IsNullOrEmpty(txtRegistration.Text))
            ComputeValidationErrors(true, false);
        if (string.IsNullOrEmpty(txtPassword.Text))
            ComputeValidationErrors(false, true);
    }

    private void txtPassword_TextChanged(object sender, EventArgs e)
    {
        CleanValidations(false, true);
    }
}