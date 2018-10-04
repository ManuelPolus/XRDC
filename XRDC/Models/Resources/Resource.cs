namespace XRDC.Models
{
    /// <summary>
    /// this class represents the base information needed for each connected device.
    /// </summary>
    public abstract class Resource
    {

        public abstract int Id { get; set; }

        public abstract string Name { get; set; }

    }
}
