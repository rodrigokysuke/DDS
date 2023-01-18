using App.Extensions;
using App.Models.Repositories;

namespace App.Screens;

public partial class Main : Form
{
    public Main()
    {
        InitializeComponent();
    }

    protected override void OnClosed(EventArgs e)
    {
        base.OnClosed(e);
        Application.Exit();
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        SessionRepository.ClearSession();

        this.Navigate(typeof(Login));
    }

    private void tabEmployees_Enter(object sender, EventArgs e)
    {
        var employees = EmployeeRepository.GetAllEmployees();
        if (employees.Any())
        {
            dataEmployee.AddListToDataTable(employees, ("Id", "ID"), ("Name", "Nome"), ("Registration", "Matrícula"), ("Password", "Senha"), ("Role", "Cargo"), ("Signature", "Assinatura"), ("RegistrationDate", "Data de Cadastro"));
        }
    }
}
