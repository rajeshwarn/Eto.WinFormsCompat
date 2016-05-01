namespace System.Windows.Forms
{
    public class Button : Control
    {
        #region Public Constructors

        public Button()
        {
            EtoButton = new Eto.Forms.Button();
            EtoControl = EtoButton;
            EtoButton.Click += (s, e) => Click?.Invoke(s, e);
        }

        #endregion Public Constructors

        #region Public Properties

        public Eto.Forms.Button EtoButton { get; }

        public string Text
        {
            get { return EtoButton.Text; }
            set { EtoButton.Text = value; }
        }

        #endregion Public Properties

        #region Public Events

        public event EventHandler Click;

        #endregion Public Events
    }
}