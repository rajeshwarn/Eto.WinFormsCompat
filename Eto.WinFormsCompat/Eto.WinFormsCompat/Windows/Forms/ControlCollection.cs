using System.Collections.ObjectModel;
using System.CompatUtils;

namespace System.Windows.Forms
{
    public class ControlCollection : Collection<Control>
    {
        private ContainerControl containerControl;

        public ControlCollection(ContainerControl containerControl)
        {
            this.containerControl = containerControl;
        }

        protected override void InsertItem(int index, Control control)
        {
            base.InsertItem(index, control);
            containerControl.EtoLayout.Add(control.EtoControl, CompatConverter.SystemDrawingPointToEtoDrawingPoint(control.Location));
        }
    }
}