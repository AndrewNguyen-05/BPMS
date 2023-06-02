using BPMS.Classes;
using BPMS.DAO;
using BPMS.GUI;
using BPMS.GUI.Agency;
using BPMS.GUI.Publisher;
using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BPMS
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        internal int AccountId;
        //Constructor
        public FormMainMenu(int accountId)
        {
            InitializeComponent();
            OpenChildForm(new FormHome());
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, btnImport.Height);
            panelMenu.Controls.Add(leftBorderBtn); 


            #region Border buttons
            //Close
            Guna2Elipse elipse_close = new Guna2Elipse();
            elipse_close.TargetControl = controlClose;
            elipse_close.BorderRadius = 35;

            //Minimize
            Guna2Elipse elipse_minimize = new Guna2Elipse();
            elipse_minimize.TargetControl = controlMinimize;
            elipse_minimize.BorderRadius = 35;

            //Log out
            Guna2Elipse elipse_out = new Guna2Elipse();
            elipse_out.TargetControl = btnLogOut;
            elipse_out.BorderRadius = 30;
            #endregion


            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //Account & Perm
            AccountId = accountId; 
            InitialPerm();
        }
        #region Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(245, 17, 166);
            public static Color color3 = Color.FromArgb(253, 35, 20);
            public static Color color4 = Color.FromArgb(98, 0, 238);
            public static Color color5 = Color.FromArgb(17, 164, 35);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(208, 0, 250);
        }
        #endregion

        #region Permission
        void InitialPerm()
        {
            Permissions type = AccountDAO.Instance.GetAccountType(AccountId);
            if (type == Permissions.Admin)
            {
                cbViewAs.Visible = true;
                cbViewAs.SelectedIndex = 0;
            }
            CheckPermisison();
        }
        Permissions GetCbViewAsValue()
        {
            if (cbViewAs.SelectedItem == null) return Permissions.Admin;
            if (cbViewAs.SelectedItem.ToString() == "Manager") return Permissions.Manager;
            else if (cbViewAs.SelectedItem.ToString() == "Publisher") return Permissions.Publisher;
            else if (cbViewAs.SelectedItem.ToString() == "Accountant") return Permissions.Accountant;
            else if (cbViewAs.SelectedItem.ToString() == "Agency") return Permissions.Agency;
            return Permissions.Admin;
        }
        private void cbViewAs_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckPermisison();
        }
        private void CheckPermisison()
        {
            Permissions type = AccountDAO.Instance.GetAccountType(AccountId);
            if (type == Permissions.Admin)
            {
                btnAnalytic.Visible = true;
                btnExport.Visible = true;
                btnImport.Visible = true;
                btnPayment.Visible = true;
                btnAccount.Visible = true;
                type = GetCbViewAsValue();
            }
            switch (type)
            {
                case Permissions.Manager:

                    return;
                case Permissions.Accountant:
                    btnAnalytic.Visible = false;
                    btnExport.Visible = false;
                    btnImport.Visible = false;
                    btnPayment.Visible = false;
                    return;
                case Permissions.Publisher:
                    btnImport.Visible = false;
                    btnAnalytic.Visible = false;
                    return;
                case Permissions.Agency:
                    btnExport.Visible = false;
                    btnAnalytic.Visible = false;
                    return;
            }
        }
        #endregion

        #region Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(241, 243, 245);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(252, 228, 236);
                currentBtn.ForeColor = Color.FromArgb(0, 152, 179);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(0, 152, 179);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;

        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }

        #region Get Form
        private Form GetBtnImportForm()
        {
            Permissions type = AccountDAO.Instance.GetAccountType(AccountId);
            if (type == Permissions.Admin)
            {
                type = GetCbViewAsValue();
            }
            switch (type)
            {
                case Permissions.Manager:
                    FormImport formImport = new FormImport();
                    formImport.InnerFormNavigating += Formimport_InnerFormNavigating;
                    return formImport;
                case Permissions.Agency:
                    return new FormAgencyImport();
            }
            return null;
        }
        private Form GetBtnExportForm()
        {
            Permissions type = AccountDAO.Instance.GetAccountType(AccountId);
            if (type == Permissions.Admin)
            {
                type = GetCbViewAsValue();
            }
            switch (type)
            {
                case Permissions.Manager:
                    FormExport formExport = new FormExport();
                    formExport.InnerFormNavigating += FormExport_InnerFormNavigating;
                    return formExport;
                case Permissions.Publisher:
                    return new FormPublisherExport();
            }
            return null;
        }
        private Form GetBtnPaymentForm()
        {
            Permissions type = AccountDAO.Instance.GetAccountType(AccountId);
            if (type == Permissions.Admin)
            {
                type = GetCbViewAsValue();
            }
            switch (type)
            {
                case Permissions.Manager:
                    FormPayment formPayment = new FormPayment();
                    formPayment.InnerFormNavigating += FormPayment_InnerFormNavigating; 
                    return formPayment;
                case Permissions.Agency:
                    return new FormAgencyPayment();
                case Permissions.Publisher:
                    return new FormPublisherPayment();
            }
            return null;
        }

        private Form GetBtnAnalyticForm()
        {
            Permissions type = AccountDAO.Instance.GetAccountType(AccountId);
            if (type == Permissions.Admin)
            {
                type = GetCbViewAsValue();
            }
            switch (type)
            {
                case Permissions.Manager:
                    return new FormAnalytic();
            }
            return null;
        }
        private Form GetBtnAccount()
        {
            Permissions type = AccountDAO.Instance.GetAccountType(AccountId);
            if (type == Permissions.Admin)
            {
                FormAccount formAccount = new FormAccount();
                formAccount.InnerFormNavigating += FormAccount_InnerFormNavigating;
                return formAccount;
            }
            return null;
        }

        #endregion

        #endregion

        #region Events

        #region Menu Buttons Click
        private void btnMainPage_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new FormHome());
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(GetBtnImportForm());
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(GetBtnExportForm());
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(GetBtnPaymentForm());
        }

        private void btnAnalytic_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(GetBtnAnalyticForm());
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(GetBtnAccount());
        }
        #endregion

        #region Buttons
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pbLogo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHome());
        }
        #endregion

        #region Inner navigate

        private void Formimport_InnerFormNavigating(object sender, NavigationEventArgs e)
        {
            FormCreateImport formCreateImport = e.NavigatingForm as FormCreateImport;
            formCreateImport.NavigateBack += FormCreateImport_NavigateBack;
            OpenChildForm(e.NavigatingForm);
        }

        private void FormCreateImport_NavigateBack(object sender, NavigationEventArgs e)
        {
            ActivateButton(btnImport, RGBColors.color5);
            FormImport formimport = e.NavigatingForm as FormImport;
            formimport.InnerFormNavigating += Formimport_InnerFormNavigating;
            OpenChildForm(formimport);
        }

        private void FormExport_InnerFormNavigating(object sender, NavigationEventArgs e)
        {
            FormCreateExport formCreateExport = e.NavigatingForm as FormCreateExport;
            formCreateExport.NavigateBack += FormCreateExport_NavigateBack;
            OpenChildForm(e.NavigatingForm);
        }

        private void FormCreateExport_NavigateBack(object sender, NavigationEventArgs e)
        {
            ActivateButton(btnExport, RGBColors.color2);
            FormExport formExport = e.NavigatingForm as FormExport;
            formExport.InnerFormNavigating += FormExport_InnerFormNavigating;
            OpenChildForm(formExport);
        }
        private void FormAccount_InnerFormNavigating(object sender, NavigationEventArgs e)
        {
            FormCreateAccount formCreateAccount = e.NavigatingForm as FormCreateAccount;
            formCreateAccount.NavigateBack += FormCreateAccount_NavigateBack;
            OpenChildForm(e.NavigatingForm);
        }

        private void FormCreateAccount_NavigateBack(object sender, NavigationEventArgs e)
        {
            ActivateButton(btnAccount, RGBColors.color7);
            FormAccount formAccount = e.NavigatingForm as FormAccount;
            formAccount.InnerFormNavigating += FormAccount_InnerFormNavigating;
            OpenChildForm(formAccount);
        }

        private void FormPayment_InnerFormNavigating(object sender, NavigationEventArgs e)
        {
            FormCreateBill formCreateBill = e.NavigatingForm as FormCreateBill;
            formCreateBill.NavigateBack += FormCreateBill_NavigateBack;
            OpenChildForm(e.NavigatingForm);
        }

        private void FormCreateBill_NavigateBack(object sender, NavigationEventArgs e)
        {
            ActivateButton(btnPayment, RGBColors.color3);
            FormPayment formPayment = e.NavigatingForm as FormPayment;
            formPayment.InnerFormNavigating += FormPayment_InnerFormNavigating;
            OpenChildForm(formPayment);
        }



        #endregion

        #region Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void panelDesktop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pbLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }






        #endregion

        #region Closing Form
        private void FormMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (currentChildForm is null) return;
            currentChildForm.Close();
            if (currentChildForm.IsHandleCreated)
            {
                e.Cancel = true;
                return;
            }
        }
        private void FormMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }


        #endregion

        #endregion

    }
}
