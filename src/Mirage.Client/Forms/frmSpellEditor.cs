using Mirage.Modules;

namespace Mirage.Forms;

public partial class frmSpellEditor : Form
{
    public frmSpellEditor()
    {
        InitializeComponent();
    }

    private void frmSpellEditor_Load(object sender, EventArgs e)
    {
        cmbClassReq.Items.Add("All Classes");
        for (var i = 0; i < modTypes.Max_Classes; i++)
        {
            cmbClassReq.Items.Add(modTypes.Class[i].Name);
        }

        txtName.Text = modTypes.Spell[modGameLogic.EditorIndex].Name;
        cmbClassReq.SelectedIndex = modTypes.Spell[modGameLogic.EditorIndex].ClassReq;
        scrlLevelReq.Value = modTypes.Spell[modGameLogic.EditorIndex].LevelReq;
        lblLevelReq.Text = scrlLevelReq.Value.ToString();
        cmbType.SelectedIndex = modTypes.Spell[modGameLogic.EditorIndex].Type;

        if (modTypes.Spell[modGameLogic.EditorIndex].Type != modTypes.SPELL_TYPE_GIVEITEM)
        {
            fraVitals.Visible = true;
            fraGiveItem.Visible = false;
            scrlVitalMod.Value = modTypes.Spell[modGameLogic.EditorIndex].Data1;
            lblVitalMod.Text = scrlVitalMod.Value.ToString();
        }
        else
        {
            fraVitals.Visible = false;
            fraGiveItem.Visible = true;
            scrlItemNum.Value = modTypes.Spell[modGameLogic.EditorIndex].Data1;
            fraGiveItem.Text = $"Give Item {modTypes.Item[scrlItemNum.Value].Name.Trim()}";
            lblItemNum.Text = scrlItemNum.Value.ToString();
            scrlItemValue.Value = modTypes.Spell[modGameLogic.EditorIndex].Data2;
            lblItemValue.Text = scrlItemValue.Value.ToString();
        }
    }

    private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cmbType.SelectedIndex != modTypes.SPELL_TYPE_GIVEITEM)
        {
            fraVitals.Visible = true;
            fraGiveItem.Visible = false;
        }
        else
        {
            fraVitals.Visible = false;
            fraGiveItem.Visible = true;
        }
    }

    private void scrlItemNum_Scroll(object sender, ScrollEventArgs e)
    {
        fraGiveItem.Text = $"Give Item {modTypes.Item[scrlItemNum.Value].Name.Trim()}";
        lblItemNum.Text = scrlItemNum.Value.ToString();
    }

    private void scrlItemValue_Scroll(object sender, ScrollEventArgs e)
    {
        lblItemValue.Text = scrlItemValue.Value.ToString();
    }

    private void scrlLevelReq_Scroll(object sender, ScrollEventArgs e)
    {
        lblLevelReq.Text = scrlLevelReq.Value.ToString();
    }

    private void scrlVitalMod_Scroll(object sender, ScrollEventArgs e)
    {
        lblVitalMod.Text = scrlVitalMod.Value.ToString();
    }

    private void cmdOk_Click(object sender, EventArgs e)
    {
        modTypes.Spell[modGameLogic.EditorIndex].Name = txtName.Text;
        modTypes.Spell[modGameLogic.EditorIndex].ClassReq = cmbClassReq.SelectedIndex;
        modTypes.Spell[modGameLogic.EditorIndex].LevelReq = scrlLevelReq.Value;
        modTypes.Spell[modGameLogic.EditorIndex].Type = cmbType.SelectedIndex;

        if (cmbType.SelectedIndex != modTypes.SPELL_TYPE_GIVEITEM)
        {
            modTypes.Spell[modGameLogic.EditorIndex].Data1 = scrlVitalMod.Value;
        }
        else
        {
            modTypes.Spell[modGameLogic.EditorIndex].Data1 = scrlItemNum.Value;
            modTypes.Spell[modGameLogic.EditorIndex].Data2 = scrlItemValue.Value;
        }

        modClientTCP.SendSaveSpell(modGameLogic.EditorIndex);
        modGameLogic.InSpellEditor = false;
        Close();
    }

    private void cmdCancel_Click(object sender, EventArgs e)
    {
        modGameLogic.InSpellEditor = false;
        Close();
    }
}
