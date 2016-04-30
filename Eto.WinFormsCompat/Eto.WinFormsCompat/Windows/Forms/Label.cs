using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Windows.Forms
{
    public class Label : Control
    {
        public Eto.Forms.Label EtoLabel { get; }

        public Label()
        {
            EtoLabel = new Eto.Forms.Label();
            EtoControl = EtoLabel;
        }

        public string Text
        {
            get { return EtoLabel.Text; }
            set { EtoLabel.Text = value; }
        }
    }
}
