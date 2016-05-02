using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Windows.Forms
{
    public class ListItemCollection : Collection<object>
    {
        #region Private Fields

        private readonly List<object> _dataSource;
        private readonly Eto.Forms.ListControl _hostListControl;
        #endregion Private Fields

        #region Public Constructors

        public ListItemCollection(Eto.Forms.ListControl hostListControl)
        {
            _hostListControl = hostListControl;
            _dataSource = new List<object>();
        }

        #endregion Public Constructors

        #region Protected Methods

        protected override void ClearItems()
        {
            _dataSource.Clear();
            _hostListControl.DataStore = _dataSource;
            _hostListControl.Items.Clear();
            base.ClearItems();
        }

        protected override void InsertItem(int index, object item)
        {
            base.InsertItem(index, item);
            _dataSource.Add(item);
            _hostListControl.DataStore = _dataSource;
        }

        protected override void RemoveItem(int index)
        {
            var item = this[index];
            _dataSource.Remove(item);
            _hostListControl.DataStore = _dataSource;
            base.RemoveItem(index);
        }

        #endregion Protected Methods
    }
}