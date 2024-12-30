namespace Mirage.Forms;

public partial class frmCredits : Form
{
    public frmCredits()
    {
        InitializeComponent();
    }

    private void picCancel_Click(object sender, EventArgs e)
    {
        My.Forms.frmMainMenu.Show();
        Hide();
    }
}
