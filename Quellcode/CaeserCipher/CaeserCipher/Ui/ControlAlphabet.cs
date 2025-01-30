using CaeserCipher.Business;
using CaeserCipher.Common.Enums;

namespace CaeserCipher.Ui;
public partial class ControlAlphabet : UserControl
{
    /// <summary>
    /// Creates a new instance of the <see cref="ControlAlphabet"/>.
    /// </summary>
    public ControlAlphabet()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Shifts the cipher alphabet according to the direction and shift.
    /// </summary>
    /// <param name="direction">The desired direction.</param>
    /// <param name="shift">The shift.</param>
    public void ShiftCipher(CipherDirection direction, int shift)
    {
        var alphabet = CipherHelper.CaeserCipherAlphabetUpper;
        for (var i = 0; i < alphabet.Length; i++)
        {
            var label = GetLabel(i + 1);
            if (label == null)
                continue;

            var newChar = CipherHelper.GetChar(CipherType.Encrypt, alphabet, alphabet[i], shift, direction);
            label.Text = newChar.ToString();
            SetStyle(label, newChar);
        }
    }

    /// <summary>
    /// Gets the label of the specified entry.
    /// </summary>
    /// <param name="id">The id.</param>
    /// <returns>The label.</returns>
    private Label? GetLabel(int id)
    {
        var name = $"labelCipher{id}";
        return tableLayoutPanel.Controls.OfType<Label>().FirstOrDefault(label => label.Name.Equals(name));
    }

    /// <summary>
    /// Sets the style of the font according to the charakter (A = Bold, Rest = Regular).
    /// </summary>
    /// <param name="label">The label.</param>
    /// <param name="charakter">The charakter.</param>
    private static void SetStyle(Label label, char charakter)
    {
        label.Font = new Font(label.Font, charakter.Equals('A') ? FontStyle.Bold : FontStyle.Regular);
    }
}
