using CaeserCipher.Common.Enums;

namespace CaeserCipher.Business;

/// <summary>
/// Provides the cipher functions.
/// </summary>
internal static class CipherHelper
{
    /// <summary>
    /// The usable alphabet (lower).
    /// </summary>
    private const string CaeserCipherAlphabetLower = "abcdefghjiklmnopqrstuvwxyz";

    /// <summary>
    /// The usable alphabet (upper).
    /// </summary>
    public const string CaeserCipherAlphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    /// <summary>
    /// Encrypts / Decrypts the specified text.
    /// </summary>
    /// <param name="type">The desired type (decrypt, encrypt).</param>
    /// <param name="text">The text which should be encrypted / decrypted.</param>
    /// <param name="textType">The type of the text (lower / upper).</param>
    /// <param name="shift">The desired "shift".</param>
    /// <param name="direction">The desired direction (left / right).</param>
    /// <returns>The encrypted / decrypted text.</returns>
    public static string EncryptDecrypt(CipherType type, string text, CipherTextType textType, int shift, CipherDirection direction)
    {
        var result = string.Empty;
        var alphabet = textType == CipherTextType.Upper ? CaeserCipherAlphabetUpper : CaeserCipherAlphabetLower;

        return text.Select(t => GetChar(type, alphabet, t, shift, direction)).Aggregate(result, (current, newChar) => current + newChar);
    }

    /// <summary>
    /// Gets the new char according to the specified values.
    /// </summary>
    /// <param name="type">The desired type (decrypt, encrypt).</param>
    /// <param name="alphabet">The alphabet which should be used.</param>
    /// <param name="sourceChar">The char which should be "converted".</param>
    /// <param name="shift">The desired "shift".</param>
    /// <param name="direction">The desired direction (left / right).</param>
    /// <returns>The new character.</returns>
    public static char GetChar(CipherType type, string alphabet, char sourceChar, int shift, CipherDirection direction)
    {
        var maxLength = alphabet.Length;

        var charIndex = alphabet.IndexOf(sourceChar);
        if (charIndex == -1) // The char does not appear in our alphabet, so return it directly.
            return sourceChar;

        // Switch the direction for the decryption
        if (type == CipherType.Decrypt)
            direction = direction == CipherDirection.Left ? CipherDirection.Right : CipherDirection.Left;

        // Get the index of the new character
        var newCharIndex = direction == CipherDirection.Right
            ? charIndex - shift // Move to the left > Example: D = 4, Shift = 3 > 4 - 3 = 1 > A
            : charIndex + shift; // Move to the right > Example: D = 4, Shift = 3, 4 + 3 = 7 > G

        // Security check to make sure that we are in the correct range
        if (newCharIndex >= maxLength)
            newCharIndex -= maxLength;
        else if (newCharIndex < 0)
            newCharIndex += maxLength;

        return alphabet[newCharIndex];
    }
}
