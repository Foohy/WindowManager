using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowManager
{
    public partial class Advanced : Form
    {
        public Advanced()
        {
            InitializeComponent();
        }

        //KILL. ME.
        public void PopulateCheckboxes(int hWnd)
        {
            User32.tagWINDOWINFO info = new User32.tagWINDOWINFO();
            User32.GetWindowInfo(hWnd, out info);

            ClearChecks();

            if ((info.dwStyle & User32.WS_BORDER) != 0)
                winOptions.SetItemChecked( 0, true );
            if ((info.dwStyle & User32.WS_CAPTION) != 0)
                winOptions.SetItemChecked( 1, true );
            if ((info.dwStyle & User32.WS_CHILD) != 0)
                winOptions.SetItemChecked( 2, true );
            if ((info.dwStyle & User32.WS_CLIPCHILDREN) != 0)
                winOptions.SetItemChecked( 3, true );
            if ((info.dwStyle & User32.WS_CLIPSIBLINGS) != 0)
                winOptions.SetItemChecked( 4, true );
            if ((info.dwStyle & User32.WS_DISABLED) != 0)
                winOptions.SetItemChecked( 5, true );
            if ((info.dwStyle & User32.WS_DLGFRAME) != 0)
                winOptions.SetItemChecked( 6, true );
            if ((info.dwStyle & User32.WS_GROUP) != 0)
                winOptions.SetItemChecked( 7, true );
            if ((info.dwStyle & User32.WS_HSCROLL) != 0)
                winOptions.SetItemChecked( 8, true );
            if ((info.dwStyle & User32.WS_MAXIMIZE) != 0)
                winOptions.SetItemChecked( 9, true );
            if ((info.dwStyle & User32.WS_MAXIMIZEBOX) != 0)
                winOptions.SetItemChecked( 10, true );
            if ((info.dwStyle & User32.WS_MINIMIZE) != 0)
                winOptions.SetItemChecked(11, true);
            if ((info.dwStyle & User32.WS_MINIMIZEBOX) != 0)
                winOptions.SetItemChecked(12, true);
            if ((info.dwStyle & User32.WS_OVERLAPPED) != 0)
                winOptions.SetItemChecked(13, true);
            if ((info.dwStyle & User32.WS_POPUP) != 0)
                winOptions.SetItemChecked(14, true);
            if ((info.dwStyle & User32.WS_SYSMENU) != 0)
                winOptions.SetItemChecked(15, true);
            if ((info.dwStyle & User32.WS_TABSTOP) != 0)
                winOptions.SetItemChecked(16, true);
            if ((info.dwStyle & User32.WS_THICKFRAME) != 0)
                winOptions.SetItemChecked(17, true);
            if ((info.dwStyle & User32.WS_VISIBLE) != 0)
                winOptions.SetItemChecked(18, true);
            if ((info.dwStyle & User32.WS_VSCROLL) != 0)
                winOptions.SetItemChecked(19, true);
        }

        public bool isChecked( int i )
        {
            return winOptions.GetItemCheckState(i) == CheckState.Checked;
        }

        public int CheckedAmount()
        {
            return winOptions.Items.Count;
        }

        private void ClearChecks()
        {
            for (int i = 0; i < winOptions.Items.Count; i++)
            {
                winOptions.SetItemChecked(i, false);
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
