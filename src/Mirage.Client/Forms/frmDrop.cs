using Mirage.Modules;

namespace Mirage.Forms;

public partial class frmDrop : Form
{
    private int _amount;

    public frmDrop()
    {
        InitializeComponent();
    }

    private void frmDrop_Load(object sender, EventArgs e)
    {
        _amount = 1;

        var invNum = My.Forms.frmMirage.lstInv.SelectedIndex + 1;

        lblName.Text = modTypes.Item[modTypes.GetPlayerInvItemNum(modGameLogic.MyIndex, invNum)].Name.Trim();

        AddAmount(0);
    }

    private void cmdOk_Click(object sender, EventArgs e)
    {
        var invNum = My.Forms.frmMirage.lstInv.SelectedIndex + 1;

        modClientTCP.SendDropItem(invNum, _amount);

        Close();
    }

    private void cmdCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void cmdPlus1_Click(object sender, EventArgs e)
    {
        AddAmount(1);
    }

    private void cmdMinus1_Click(object sender, EventArgs e)
    {
        AddAmount(-1);
    }

    private void cmdPlus10_Click(object sender, EventArgs e)
    {
        AddAmount(10);
    }

    private void cmdMinus10_Click(object sender, EventArgs e)
    {
        AddAmount(-10);
    }

    private void cmdPlus100_Click(object sender, EventArgs e)
    {
        AddAmount(100);
    }

    private void cmdMinus100_Click(object sender, EventArgs e)
    {
        AddAmount(-100);
    }

    private void cmdPlus1000_Click(object sender, EventArgs e)
    {
        AddAmount(1000);
    }

    private void cmdMinus1000_Click(object sender, EventArgs e)
    {
        AddAmount(-1000);
    }

    private void AddAmount(int change)
    {
        _amount += change;

        var invNum = My.Forms.frmMirage.lstInv.SelectedIndex + 1;

        // Check if more then max and set back to max if so
        var maxAmount = modTypes.GetPlayerInvItemValue(modGameLogic.MyIndex, invNum);
        if (_amount > maxAmount)
        {
            _amount = maxAmount;
        }

        // Make sure its not 0
        if (_amount < 1)
        {
            _amount = 1;
        }


        lblAmount.Text = $"{_amount}/{maxAmount}";
    }

}
