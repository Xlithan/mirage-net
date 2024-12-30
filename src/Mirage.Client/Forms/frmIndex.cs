using Mirage.Modules;

namespace Mirage.Forms;

public partial class frmIndex : Form
{
	public frmIndex()
	{
		InitializeComponent();
	}

	private void cmdOk_Click(object sender, EventArgs e)
	{
		modGameLogic.EditorIndex = lstIndex.SelectedIndex + 1;
		if (modGameLogic.InItemsEditor)
		{
			modClientTCP.SendData("EDITITEM" + modTypes.SEP_CHAR + modGameLogic.EditorIndex + modTypes.SEP_CHAR);
		}
		if (modGameLogic.InNpcEditor)
		{
			modClientTCP.SendData("EDITNPC" + modTypes.SEP_CHAR + modGameLogic.EditorIndex + modTypes.SEP_CHAR);
		}
		if (modGameLogic.InShopEditor)
		{
			modClientTCP.SendData("EDITSHOP" + modTypes.SEP_CHAR + modGameLogic.EditorIndex + modTypes.SEP_CHAR);
		}
		if (modGameLogic.InSpellEditor)
		{
			modClientTCP.SendData("EDITSPELL" + modTypes.SEP_CHAR + modGameLogic.EditorIndex + modTypes.SEP_CHAR);
		}
		Close();
	}
	
	private void cmdCancel_Click(object sender, EventArgs e)
	{
		modGameLogic.InItemsEditor = false;
		modGameLogic.InNpcEditor = false;
		modGameLogic.InShopEditor = false;
		modGameLogic.InSpellEditor = false;
		Close();
	}
}
