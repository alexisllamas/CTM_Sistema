using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace Ctm_Col
{
    public partial class MaterialTextBox : UserControl
    {
        [Category("Appearance")]
        [Description("The placeholder displayed by the control.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public String Placeholder
        {
            set
            {
                placeholder.Text = value;
            }
            get
            {
                return placeholder.Text;
            }
        }
        
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        override public String Text
        {
            set
            {
                txt.Text = value;
            }
            get
            {
                return txt.Text;
            }
        }
        public MaterialTextBox()
        {
            InitializeComponent();

        }
        
    }
}
