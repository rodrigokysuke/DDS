namespace App.Screens;

partial class Main
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
        this.btnLogout = new System.Windows.Forms.Button();
        this.tabControl = new System.Windows.Forms.TabControl();
        this.tabGeneral = new System.Windows.Forms.TabPage();
        this.tabEmployees = new System.Windows.Forms.TabPage();
        this.dataEmployee = new System.Windows.Forms.DataGridView();
        this.tabEvents = new System.Windows.Forms.TabPage();
        this.tabSignatures = new System.Windows.Forms.TabPage();
        this.tabControl.SuspendLayout();
        this.tabEmployees.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataEmployee)).BeginInit();
        this.SuspendLayout();
        // 
        // btnLogout
        // 
        this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnLogout.BackColor = System.Drawing.Color.Red;
        this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnLogout.ForeColor = System.Drawing.Color.White;
        this.btnLogout.Location = new System.Drawing.Point(1219, 650);
        this.btnLogout.Name = "btnLogout";
        this.btnLogout.Size = new System.Drawing.Size(43, 28);
        this.btnLogout.TabIndex = 0;
        this.btnLogout.Text = "Sair";
        this.btnLogout.UseVisualStyleBackColor = false;
        this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
        // 
        // tabControl
        // 
        this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
        this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.tabControl.Controls.Add(this.tabGeneral);
        this.tabControl.Controls.Add(this.tabEmployees);
        this.tabControl.Controls.Add(this.tabEvents);
        this.tabControl.Controls.Add(this.tabSignatures);
        this.tabControl.ItemSize = new System.Drawing.Size(48, 30);
        this.tabControl.Location = new System.Drawing.Point(-3, -3);
        this.tabControl.Name = "tabControl";
        this.tabControl.SelectedIndex = 0;
        this.tabControl.Size = new System.Drawing.Size(1270, 684);
        this.tabControl.TabIndex = 1;
        // 
        // tabGeneral
        // 
        this.tabGeneral.Location = new System.Drawing.Point(4, 4);
        this.tabGeneral.Name = "tabGeneral";
        this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
        this.tabGeneral.Size = new System.Drawing.Size(1262, 646);
        this.tabGeneral.TabIndex = 0;
        this.tabGeneral.Text = "Geral";
        this.tabGeneral.UseVisualStyleBackColor = true;
        // 
        // tabEmployees
        // 
        this.tabEmployees.Controls.Add(this.dataEmployee);
        this.tabEmployees.Location = new System.Drawing.Point(4, 4);
        this.tabEmployees.Name = "tabEmployees";
        this.tabEmployees.Padding = new System.Windows.Forms.Padding(3);
        this.tabEmployees.Size = new System.Drawing.Size(1262, 646);
        this.tabEmployees.TabIndex = 1;
        this.tabEmployees.Text = "Funcionários";
        this.tabEmployees.UseVisualStyleBackColor = true;
        this.tabEmployees.Enter += new System.EventHandler(this.tabEmployees_Enter);
        // 
        // dataEmployee
        // 
        this.dataEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.dataEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dataEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataEmployee.Location = new System.Drawing.Point(6, 6);
        this.dataEmployee.Name = "dataEmployee";
        this.dataEmployee.RowTemplate.Height = 25;
        this.dataEmployee.Size = new System.Drawing.Size(1250, 634);
        this.dataEmployee.TabIndex = 0;
        this.dataEmployee.ForeColor = System.Drawing.Color.Black;
        // 
        // tabEvents
        // 
        this.tabEvents.Location = new System.Drawing.Point(4, 4);
        this.tabEvents.Name = "tabEvents";
        this.tabEvents.Padding = new System.Windows.Forms.Padding(3);
        this.tabEvents.Size = new System.Drawing.Size(1262, 646);
        this.tabEvents.TabIndex = 2;
        this.tabEvents.Text = "Eventos";
        this.tabEvents.UseVisualStyleBackColor = true;
        // 
        // tabSignatures
        // 
        this.tabSignatures.Location = new System.Drawing.Point(4, 4);
        this.tabSignatures.Name = "tabSignatures";
        this.tabSignatures.Padding = new System.Windows.Forms.Padding(3);
        this.tabSignatures.Size = new System.Drawing.Size(1262, 646);
        this.tabSignatures.TabIndex = 3;
        this.tabSignatures.Text = "Assinaturas";
        this.tabSignatures.UseVisualStyleBackColor = true;
        // 
        // Main
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1264, 681);
        this.Controls.Add(this.btnLogout);
        this.Controls.Add(this.tabControl);
        this.ForeColor = System.Drawing.Color.WhiteSmoke;
        this.MinimumSize = new System.Drawing.Size(800, 600);
        this.Name = "Main";
        this.Text = "Painel";
        this.tabControl.ResumeLayout(false);
        this.tabEmployees.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dataEmployee)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private Button btnLogout;
    private TabControl tabControl;
    private TabPage tabGeneral;
    private TabPage tabEmployees;
    private TabPage tabEvents;
    private TabPage tabSignatures;
    private DataGridView dataEmployee;
}