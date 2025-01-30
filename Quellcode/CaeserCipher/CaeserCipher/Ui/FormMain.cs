using CaeserCipher.Business;
using CaeserCipher.Common;
using CaeserCipher.Common.Enums;
using CaeserCipher.Model;

namespace CaeserCipher.Ui;
public partial class FormMain : Form
{
    /// <summary>
    /// Creates a new instance of the <see cref="FormMain"/>.
    /// </summary>
    public FormMain()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Updates the cipher text info.
    /// </summary>
    private void SetCipherTextInfo()
    {
        if (comboBoxDirection.SelectedItem is not IdNamEntry entry)
            return;

        controlAlphabet.ShiftCipher((CipherDirection)entry.Id, (int)numericUpDownShift.Value);
    }

    /// <summary>
    /// Occurs when the form was loaded.
    /// </summary>
    /// <param name="sender">The <see cref="FormMain"/>.</param>
    /// <param name="e">The event arguments.</param>
    private void FormMain_Load(object sender, EventArgs e)
    {
        AddItems(comboBoxDirection, Helper.GetDirectionList());
        AddItems(comboBoxTextType, Helper.GetTextTypeList());
        AddItems(comboBoxCipherType, Helper.GetTypeList());
    }

    /// <summary>
    /// Occurs when the user changes the shift value.
    /// </summary>
    /// <param name="sender">The <see cref="numericUpDownShift"/>.</param>
    /// <param name="e">The event arguments.</param>
    private void numericUpDownShift_ValueChanged(object sender, EventArgs e)
    {
        SetCipherTextInfo();
    }

    /// <summary>
    /// Occurs when the user selects another direction.
    /// </summary>
    /// <param name="sender">The <see cref="comboBoxDirection"/>.</param>
    /// <param name="e">The event arguments</param>
    private void comboBoxDirection_SelectedIndexChanged(object sender, EventArgs e)
    {
        SetCipherTextInfo();
    }

    #region Helper
    /// <summary>
    /// Adds the specified items to the combo box.
    /// </summary>
    /// <param name="comboBox">The combo box.</param>
    /// <param name="items">The list with the items.</param>
    private static void AddItems(ComboBox comboBox, List<IdNamEntry> items)
    {
        comboBox.Items.Clear();

        foreach (var item in items)
        {
            comboBox.Items.Add(item);
        }

        comboBox.SelectedIndex = 0;
    }
    
    #endregion

    /// <summary>
    /// Occurs when the user hits the "GO!" button
    /// </summary>
    /// <param name="sender">The <see cref="buttonChange"/>.</param>
    /// <param name="e">The event arguments.</param>
    private void buttonChange_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxInput.Text))
            return;

        if (comboBoxDirection.SelectedItem is not IdNamEntry direction)
            return;

        if (comboBoxTextType.SelectedItem is not IdNamEntry textType)
            return;

        if (comboBoxCipherType.SelectedItem is not IdNamEntry cipherType)
            return;

        try
        {
            textBoxOutput.Text = CipherHelper.EncryptDecrypt(
                (CipherType)cipherType.Id,
                textBoxInput.Text,
                (CipherTextType)textType.Id,
                (int)numericUpDownShift.Value,
                (CipherDirection)direction.Id);
        }
        catch
        {
            MessageBox.Show("An error has occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
