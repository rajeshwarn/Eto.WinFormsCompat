namespace System.CompatUtils
{
    internal class CompatConverter
    {
        #region Public Methods

        public static Eto.Drawing.Size SystemDrawingSizeToEtoDrawingSize(System.Drawing.Size size)
        {
            return new Eto.Drawing.Size(size.Width, size.Height);
        }

        public static System.Drawing.Size EtoDrawingSizeToSystemDrawingSize(Eto.Drawing.Size size)
        {
            return new System.Drawing.Size(size.Width, size.Height);
        }

        #endregion Public Methods
    }
}