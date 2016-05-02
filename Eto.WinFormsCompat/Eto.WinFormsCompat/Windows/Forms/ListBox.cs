namespace System.Windows.Forms
{
    public class ListBox : Control
    {
        #region Public Constructors

        public ListBox()
        {
            EtoListBox = new Eto.Forms.ListBox();
            EtoControl = EtoListBox;
            Items = new ListItemCollection(EtoListBox);
        }

        #endregion Public Constructors

        #region Public Properties

        public Eto.Forms.ListBox EtoListBox { get; }

        [EtoWinFormsCompatStubOnly]
        public bool FormattingEnabled { get; set; }

        [EtoWinFormsCompatStubOnly]
        public int ItemHeight { get; set; }

        public ListItemCollection Items { get; }

        #endregion Public Properties
    }
}