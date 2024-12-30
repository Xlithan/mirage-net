using Mirage.Modules;

namespace Mirage.Forms;

public partial class frmMainMenu : Form
{
    public frmMainMenu()
    {
        InitializeComponent();
    }

    private void picNewAccount_Click(object sender, EventArgs e)
    {
        My.Forms.frmNewAccount.Show();
        Hide();
    }

    private void picDeleteAccount_Click(object sender, EventArgs e)
    {
        var yesNo = MessageBox.Show(
            "You are on the path for a character deletion, are you sure you want to go through with this?",
            modTypes.GAME_NAME,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (yesNo == DialogResult.No)
        {
            return;
        }

        My.Forms.frmDeleteAccount.Show();
        Hide();
    }

    private void picLogin_Click(object sender, EventArgs e)
    {
        My.Forms.frmLogin.Show();
        Hide();
    }

    private void picCredits_Click(object sender, EventArgs e)
    {
        My.Forms.frmCredits.Show();
        Hide();
    }

    private void picQuit_Click(object sender, EventArgs e)
    {
        modGameLogic.GameDestroy();
    }
}