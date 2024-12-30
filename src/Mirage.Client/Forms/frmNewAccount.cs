using Mirage.Modules;

namespace Mirage.Forms;

public partial class frmNewAccount : Form
{
    public frmNewAccount()
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
        if (txtName.Text.Trim().Length == 0 ||
            txtPassword.Text.Trim().Length == 0)
        {
            return;
        }

        var name = txtName.Text.Trim();

        // Prevent high ascii chars
        if (name.Any(c => c < 32 || c > 128))
        {
            MessageBox.Show(
                "You cannot use high ascii chars in your name, please reenter.",
                modTypes.GAME_NAME,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            txtName.Text = "";
            return;
        }
        
        modGameLogic.MenuState(modGameLogic.MENU_STATE_NEWACCOUNT);
    }
}