using System.CompatUtils;
using Eto.Drawing;

namespace System.Windows.Forms
{
    /// <summary>
    /// Represents the base class for controls on the Eto WinForms Compatibility Layer
    /// </summary>
    public abstract class Control
    {
        private Eto.Drawing.Control
        #region Public Methods 

        [EtoWinFormsCompatStubOnly]
        public void PerformLayout()
        {
        }

        public override void ResumeLayout()
        {
            base.ResumeLayout();
        }

        public void ResumeLayout(bool none)
        {
            ResumeLayout();
        }

        #endregion Public Methods

        #region Public Properties

        public override Size Size { get; set; }

        public override System.Drawing.Size ClientSize
        {
            get { return CompatConverter.SystemDrawingSizeToEtoDrawingSize(this.ClientSize); }
            set { SetSize(value); }
        }

        #endregion Public Properties
    }
}