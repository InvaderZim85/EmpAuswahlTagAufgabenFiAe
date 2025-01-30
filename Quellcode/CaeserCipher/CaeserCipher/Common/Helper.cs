using CaeserCipher.Common.Enums;
using CaeserCipher.Model;

namespace CaeserCipher.Common;

/// <summary>
/// Provides several helper methods.
/// </summary>
internal static class Helper
{
    /// <summary>
    /// Gets the list with the different <see cref="CipherDirection"/>.
    /// </summary>
    /// <returns>The list with the directions.</returns>
    public static List<IdNamEntry> GetDirectionList()
    {
        return (from entry in Enum.GetValues<CipherDirection>()
            select new IdNamEntry((int)entry, entry.ToString())).ToList();
    }

    /// <summary>
    /// Gets the list with the different <see cref="CipherTextType"/>.
    /// </summary>
    /// <returns>The list with the text types.</returns>
    public static List<IdNamEntry> GetTextTypeList()
    {
        return (from entry in Enum.GetValues<CipherTextType>()
            select new IdNamEntry((int)entry, entry.ToString())).ToList();
    }

    /// <summary>
    /// Gets the list with the different <see cref="CipherType"/>.
    /// </summary>
    /// <returns>The list with the types.</returns>
    public static List<IdNamEntry> GetTypeList()
    {
        return (from entry in Enum.GetValues<CipherType>()
            select new IdNamEntry((int)entry, entry.ToString())).ToList();
    }
}
