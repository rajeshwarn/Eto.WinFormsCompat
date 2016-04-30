namespace System.Windows.Forms
{
    public class ContainerControl : Control
    {
        #region Public Properties

        public ControlCollection Controls { get; set; }

        public Eto.Forms.PixelLayout EtoLayout { get; }

        #endregion Public Properties

        #region Public Constructors

        public ContainerControl()
        {
            Controls = new ControlCollection(this);
            EtoLayout = new Eto.Forms.PixelLayout();
        }

        #endregion Public Constructors
    }
}