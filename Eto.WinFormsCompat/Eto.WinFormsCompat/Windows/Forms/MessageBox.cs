namespace System.Windows.Forms
{
    public class MessageBox
    {
        #region Public Methods

        public static void Show(string text)
        {
            Eto.Forms.MessageBox.Show(text, "");
        }

        public static void Show(string text, string title)
        {
            Eto.Forms.MessageBox.Show(text, title);
        }

        #endregion Public Methods
    }
}