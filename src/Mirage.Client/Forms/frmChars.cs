using Mirage.Modules;

namespace Mirage.Forms;

public partial class frmChars : Form
{
	public frmChars()
	{
		InitializeComponent();
	}

	private void picCancel_Click(object sender, EventArgs e)
	{
		modClientTCP.TcpDestroy();
		My.Forms.frmLogin.Show();
		Hide();
	}
	
	private void picNewChar_Click(object sender, EventArgs e)
	{
		modGameLogic.MenuState(modGameLogic.MENU_STATE_NEWCHAR);
	}

	private void picUseChar_Click(object sender, EventArgs e)
	{
		modGameLogic.MenuState(modGameLogic.MENU_STATE_USECHAR);
	}

	private void picDelChar_Click(object sender, EventArgs e)
	{
		var value = MessageBox.Show("Are you sure you wish to delete this character?", modTypes.GAME_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		if (value == DialogResult.Yes)
		{
			modGameLogic.MenuState(modGameLogic.MENU_STATE_DELCHAR);
		}
	}
}
