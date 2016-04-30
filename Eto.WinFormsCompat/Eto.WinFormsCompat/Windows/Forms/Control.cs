using System.CompatUtils;
using System.Drawing;

namespace System.Windows.Forms
{
    /// <summary>
    /// Represents the base class for controls on the Eto WinForms Compatibility Layer
    /// </summary>
    public abstract class Control
    {
        #region Private Fields

        public Eto.Forms.Control EtoControl { get; set; }

        #endregion Private Fields

        #region Public Methods

        [EtoWinFormsCompatStubOnly]
        public void PerformLayout()
        {
        }

        public void ResumeLayout()
        {
            EtoControl.ResumeLayout();
        }

        public void ResumeLayout(bool none)
        {
            ResumeLayout();
        }

        public void SuspendLayout()
        {
            EtoControl.SuspendLayout();
        }

        [EtoWinFormsCompatStubOnly]
        protected virtual void Dispose(bool disposing)
        {
        }

        #endregion Public Methods

        #region Public Properties

        public SizeF AutoScaleDimensions { get; set; }

        [EtoWinFormsCompatStubOnly]
        public AutoScaleMode AutoScaleMode { get; set; }

        [EtoWinFormsCompatStubOnly]
        public bool AutoSize { get; set; }

        public Point Location
        {
            get { return CompatConverter.EtoDrawingPointToSystemDrawingPoint(EtoControl.Location); }
            set { Eto.Forms.PixelLayout.SetLocation(EtoControl, CompatConverter.SystemDrawingPointToEtoDrawingPoint(value)); }
        }

        [EtoWinFormsCompatStubOnly]
        public string Name { get; set; }

        public System.Drawing.Size Size
        {
            get { return CompatConverter.EtoDrawingSizeToSystemDrawingSize(EtoControl.Size); }
            set { EtoControl.Size = CompatConverter.SystemDrawingSizeToEtoDrawingSize(value); }
        }

        [EtoWinFormsCompatStubOnly]
        public int TabIndex { get; set; }

        #endregion Public Properties

        #region Public Constructors

        protected Control()
        {
            if (!Application.IsInitialized)
            {
                Application.Initialize();
            }
        }

        #endregion Public Constructors
    }
}