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
                txt.Hint = value;
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
                if (value != null)
                {
                    txt.Text = value;

                    if (value.Length > 0)
                    {
                        placeholder.Visible = true;
                    }
                } else
                {
                    txt.Text = "";
                }

            }
            get
            {
                return txt.Text;
            }
        }
        public MaterialTextBox()
        {
            InitializeComponent();
            Height = 48;      
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            placeholder.Visible = true;
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            if (txt.Text.Length <= 0)
            { 
                placeholder.Visible = false;
            }
        }

        private void MaterialTextBox_Resize(object sender, EventArgs e)
        {
            txt.Width = Width;
        }
    }
}
