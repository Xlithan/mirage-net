using Mirage.Modules;

namespace Mirage.Forms;

public partial class frmLogin : Form
{
	public frmLogin()
	{
		InitializeComponent();
	}
    
    private void picCancel_Click(object sender, EventArgs e)
	{
		My.Forms.frmMainMenu.Show();
		Hide();
	}

	private void picConnect_Click(object sender, EventArgs e)
	{
        if (txtName.Text.Trim().Length > 0 && txtPassword.Text.Trim().Length > 0)
        {
            modGameLogic.MenuState(modGameLogic.MENU_STATE_LOGIN);
        }
	}
}
