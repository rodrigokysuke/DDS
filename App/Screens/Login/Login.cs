using App.EnDecryption;
using App.Extensions;
using App.Models.Entities;
using App.Models.Repositories;

namespace App.Screens;

public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
    }

    protected override void OnClosed(EventArgs e)
    {
        base.OnClosed(e);
        Application.Exit();
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
            var employee = EmployeeRepository.GetEmployeeByLoginData(txtRegistration.Text, txtPassword.Text);
            if (employee != null)
            {
                SessionRepository.ClearSession();

                if (ckbKeepSession.Checked)
                {
                    var key = Guid.NewGuid().ToString().Replace("-", string.Empty);
                    var passwordEncrypted = AesOperation.EncryptString(key, txtPassword.Text);

                    var session = new Session
                    {
                        Registration = txtRegistration.Text,
                        PasswordEncrypted = passwordEncrypted,
                        PasswordDecryptionKey = key
                    };
                    SessionRepository.SetSession(session);
                }

                this.Navigate(typeof(Main));
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