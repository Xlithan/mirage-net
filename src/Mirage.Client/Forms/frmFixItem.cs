using Mirage.Modules;

namespace Mirage.Forms;

public partial class frmFixItem : Form
{
	public frmFixItem()
	{
		InitializeComponent();
	}

	private void chkFix_Click(object sender, EventArgs e)
	{
		modClientTCP.SendData("fixitem" + modTypes.SEP_CHAR + (cmbItem.SelectedIndex + 1) + modTypes.SEP_CHAR);
	}
	
	private void picCancel_Click(object sender, EventArgs e)
	{
		Close();
	}
}
