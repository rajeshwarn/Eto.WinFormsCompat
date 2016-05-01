using System.CompatUtils;

namespace System.Windows.Forms
{
    public class Label : TextControl
    {
        #region Public Constructors

        public Label()
        {
            EtoLabel = new Eto.Forms.Label();
            EtoControl = EtoLabel;
        }

        #endregion Public Constructors

        #region Public Properties

        public Eto.Forms.Label EtoLabel { get; }

        public System.Drawing.Font Font
        {
            set { EtoLabel.Font = CompatConverter.SystemDrawingFontToEtoFont(value); }
        }

        public string Text
        {
            get { return EtoLabel.Text; }
            set { EtoLabel.Text = value; }
        }

        #endregion Public Properties
    }
}