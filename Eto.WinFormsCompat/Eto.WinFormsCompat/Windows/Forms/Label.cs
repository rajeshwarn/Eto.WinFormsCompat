namespace System.Windows.Forms
{
    public class Label : Control
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
        public string Text
        {
            get { return EtoLabel.Text; }
            set { EtoLabel.Text = value; }
        }

        #endregion Public Properties
    }
}