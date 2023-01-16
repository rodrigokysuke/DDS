namespace App.Screens.Login;

partial class Login
{
    private void CleanValidations(bool registration = true, bool password = true)
    {
        if (registration)
            lblRegistrationValidation.Text = string.Empty;
        if (password)
            lblPasswordValidation.Text = string.Empty;
    }

    private bool ComputeValidationErrors(bool registration = true, bool password = true)
    {
        bool wasError = false;

        if (registration)
            if (string.IsNullOrEmpty(txtRegistration.Text))
            {
                lblRegistrationValidation.Text = "A matrícula é obrigatória!";
                wasError = true;
            }

        if (password)
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblPasswordValidation.Text = "A senha é obrigatória!";
                wasError = true;
            }

        return wasError;
    }
}