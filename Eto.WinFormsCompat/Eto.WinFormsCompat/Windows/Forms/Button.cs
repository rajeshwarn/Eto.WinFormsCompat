namespace System.Windows.Forms
{
    public class Button : Control
    {
        public Eto.Forms.Button EtoButton { get; }

        public Button()
        {
            EtoButton = new Eto.Forms.Button();
            EtoControl = EtoButton;
        }

        public string Text
        {
            get { return EtoButton.Text; }
            set { EtoButton.Text = value; }
        }
    }
}