using Mirage.Modules;

namespace Mirage.Forms;

public partial class frmTrade : Form
{
	public frmTrade()
	{
		InitializeComponent();
	}

	private void picDeal_Click(object sender, EventArgs e)
	{
		if (lstTrade.Items.Count > 0)
		{
			modClientTCP.SendData(
				"traderequest" + 
				modTypes.SEP_CHAR + (lstTrade.SelectedIndex + 1) + 
				modTypes.SEP_CHAR);
		}
	}

	private void picFixItems_Click(object sender, EventArgs e)
	{
		using var frmFixItem = new frmFixItem();
		
		for (var i = 0; i <= modTypes.MAX_INV; i++)
		{
			if (modTypes.GetPlayerInvItemNum(modGameLogic.MyIndex, i) > 0)
			{
				frmFixItem.cmbItem.Items.Add(modTypes.Item[modTypes.GetPlayerInvItemNum(modGameLogic.MyIndex, i)].Name.Trim());
			}
			else
			{
				frmFixItem.cmbItem.Items.Add("Unused Slot");
			}
		}

		frmFixItem.cmbItem.SelectedIndex = 0;
		frmFixItem.ShowDialog();
	}

	private void picCancel_Click(object sender, EventArgs e)
	{
		Close();
	}
}
