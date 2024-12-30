using Mirage.Modules;

namespace Mirage.Forms;

public partial class frmTraining : Form
{
    public frmTraining()
    {
        InitializeComponent();
    }

    private void frmTraining_Load(object sender, EventArgs e)
    {
        cmbStat.SelectedIndex = 0;
    }

    private void picTrain_Click(object sender, EventArgs e)
    {
        modClientTCP.SendData(
            "usestatpoint" +
            modTypes.SEP_CHAR + cmbStat.SelectedIndex +
            modTypes.SEP_CHAR);
    }

    private void picCancel_Click(object sender, EventArgs e)
    {
        Close();
    }
}