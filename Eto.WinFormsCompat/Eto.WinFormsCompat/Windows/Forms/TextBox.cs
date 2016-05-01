namespace System.Windows.Forms
{
    public class TextBox : Control
    {
        #region Public Constructors

        public TextBox()
        {
            EtoTextBox = new Eto.Forms.TextBox();
            EtoControl = EtoTextBox;
        }

        #endregion Public Constructors

        #region Public Properties

        public Eto.Forms.TextBox EtoTextBox { get; }
        public string Text
        {
            get { return EtoTextBox.Text; }
            set { EtoTextBox.Text = value; }
        }

        #endregion Public Properties
    }
}