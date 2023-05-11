using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPMS
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        //Constructor
        public FormMainMenu()
        {
            InitializeComponent();
        }
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(245, 17, 166);
            public static Color color3 = Color.FromArgb(253, 35, 20);
            public static Color color4 = Color.FromArgb(98, 0, 238);
            public static Color color5 = Color.FromArgb(17, 164, 35);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Methods
    }
}
