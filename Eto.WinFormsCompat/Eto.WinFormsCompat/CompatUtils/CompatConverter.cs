using System.Drawing;

namespace System.CompatUtils
{
    internal class CompatConverter
    {
        #region Public Methods

        public static Eto.Drawing.Size SystemDrawingSizeToEtoDrawingSize(Size size)
        {
            return new Eto.Drawing.Size(size.Width, size.Height);
        }

        public static Size EtoDrawingSizeToSystemDrawingSize(Eto.Drawing.Size size)
        {
            return new Size(size.Width, size.Height);
        }

        #endregion Public Methods

        public static Point EtoDrawingPointToSystemDrawingPoint(Eto.Drawing.Point location)
        {
            return new Point(location.X, location.Y);
        }

        public static Eto.Drawing.Point SystemDrawingPointToEtoDrawingPoint(Point location)
        {
            return new Eto.Drawing.Point(location.X, location.Y);
        }
    }
}