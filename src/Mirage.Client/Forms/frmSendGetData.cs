using Mirage.Modules;

namespace Mirage.Forms;

public partial class frmSendGetData : Form
{
    public frmSendGetData()
    {
        InitializeComponent();
    }

    private void frmSendGetData_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char) Keys.Escape)
        {
            modGameLogic.GameDestroy();
        }
    }
}
