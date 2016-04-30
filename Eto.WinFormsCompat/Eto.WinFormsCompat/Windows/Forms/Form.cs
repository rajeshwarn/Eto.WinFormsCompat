/*
 */

using System.CompatUtils;

namespace System.Windows.Forms
{
    public class Form : Control
    {
        #region Private Fields

        public Eto.Forms.Form EtoForm { get; }

        #endregion Private Fields

        #region Public Constructors

        public Form()
        {
            if (!Application.IsInitialized)
            {
                Application.Initialize();
            }
            EtoForm = new Eto.Forms.Form();
            EtoControl = EtoForm;
        }

        #endregion Public Constructors

        #region Public Properties

        public System.Drawing.Size ClientSize
        {
            get { return CompatConverter.EtoDrawingSizeToSystemDrawingSize(EtoForm.ClientSize); }
            set { EtoForm.ClientSize = CompatConverter.SystemDrawingSizeToEtoDrawingSize(value); }
        }

        public string Text
        {
            get { return EtoForm.Title; }
            set { EtoForm.Title = value; }
        }

        #endregion Public Properties
    }
}