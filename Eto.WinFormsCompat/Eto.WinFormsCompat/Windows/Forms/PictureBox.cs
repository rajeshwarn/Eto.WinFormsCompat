namespace System.Windows.Forms
{
    public class PictureBox : Control
    {
        #region Public Constructors

        public PictureBox()
        {
            EtoImageView = new Eto.Forms.ImageView();
            EtoControl = EtoImageView;
        }

        #endregion Public Constructors

        #region Public Properties

        public Eto.Forms.ImageView EtoImageView { get; }

        #endregion Public Properties
    }
}