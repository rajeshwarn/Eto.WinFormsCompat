using System.Collections.Generic;
using System.Linq;

namespace System.Windows.Forms
{
    public class ListBox : Control
    {
        public Eto.Forms.ListBox EtoListBox { get; }

        public ListBox()
        {
            EtoListBox = new Eto.Forms.ListBox();
            EtoControl = EtoListBox;
            
        }

        [EtoWinFormsCompatStubOnly]
        public bool FormattingEnabled { get; set; }

        [EtoWinFormsCompatStubOnly]
        public int ItemHeight { get; set; }

        public List<object> Items
        {
            get { return EtoListBox.DataStore.ToList(); }
            set { EtoListBox.DataStore = value; }
        }
    }
}