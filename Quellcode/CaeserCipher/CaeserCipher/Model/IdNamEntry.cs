namespace CaeserCipher.Model;

/// <summary>
/// Represents a simple id / name entry where the name is also used by the <see cref="ToString()"/> method.
/// </summary>
/// <param name="id">The id.</param>
/// <param name="name">The name.</param>
internal class IdNamEntry(int id, string name)
{
    /// <summary>
    /// Gets the id.
    /// </summary>
    public int Id { get; } = id;

    /// <summary>
    /// Gets the name;
    /// </summary>
    public string Name { get; } = name;

    /// <inheritdoc />
    public override string ToString()
    {
        return Name;
    }
}
