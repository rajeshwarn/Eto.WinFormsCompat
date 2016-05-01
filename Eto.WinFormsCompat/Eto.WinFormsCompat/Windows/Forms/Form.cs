/*
 */

using System.CompatUtils;

namespace System.Windows.Forms
{
    /// <summary>
    /// Represents a control that holds sub-controls on the Eto WinForms Compatibility Layer
    /// </summary>
    public class Form : ContainerControl
    {
        #region Private Fields

        public Eto.Forms.Form EtoForm { get; }

        #endregion Private Fields

        #region Public Constructors

        public Form()
        {
            EtoForm = new Eto.Forms.Form { Content = EtoLayout };
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