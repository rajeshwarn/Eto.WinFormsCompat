namespace System.Windows.Forms
{
    public class TextBox : Control
    {
        public Eto.Forms.TextBox EtoTextBox { get; }

        public TextBox()
        {
            EtoTextBox = new Eto.Forms.TextBox();
            EtoControl = EtoTextBox;
        }

        public string Text
        {
            get { return EtoTextBox.Text; }
            set { EtoTextBox.Text = value; }
        }
    }
}