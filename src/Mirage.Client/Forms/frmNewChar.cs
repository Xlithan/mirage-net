using Mirage.Modules;

namespace Mirage.Forms;

public partial class frmNewChar : Form
{
    public frmNewChar()
    {
        InitializeComponent();
    }

    private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblHP.Text = modTypes.Class[cmbClass.SelectedIndex].HP.ToString();
        lblMP.Text = modTypes.Class[cmbClass.SelectedIndex].MP.ToString();
        lblSP.Text = modTypes.Class[cmbClass.SelectedIndex].SP.ToString();

        lblSTR.Text = modTypes.Class[cmbClass.SelectedIndex].STR.ToString();
        lblDEF.Text = modTypes.Class[cmbClass.SelectedIndex].DEF.ToString();
        lblSPEED.Text = modTypes.Class[cmbClass.SelectedIndex].SPEED.ToString();
        lblMAGI.Text = modTypes.Class[cmbClass.SelectedIndex].MAGI.ToString();
    }

    private void picAddChar_Click(object sender, EventArgs e)
    {
        if (txtName.Text.Trim().Length == 0)
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

        modGameLogic.MenuState(modGameLogic.MENU_STATE_ADDCHAR);
    }

    private void picCancel_Click(object sender, EventArgs e)
    {
        My.Forms.frmChars.Show();
        Hide();
    }

    public void RefreshClasses()
    {
        cmbClass.Items.Clear();
        for (var i = 0; i < modTypes.Max_Classes; i++)
        {
            cmbClass.Items.Add(modTypes.Class[i].Name);
        }
        
        cmbClass.SelectedIndex = 0;
    }
}