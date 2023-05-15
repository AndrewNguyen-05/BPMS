using BPMS.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPMS
{
    internal static class Program
    {
        class BPMSApplicationContext : ApplicationContext
        {
            private FormLogin formLogin;
            private FormMainMenu[] formMainMenu;
            private int formNumber;
            public BPMSApplicationContext()
            {
                formMainMenu = new FormMainMenu[2];
                formNumber = 0;
                formLogin = new FormLogin();
                if (formLogin.ShowDialog() == DialogResult.OK)
                {
                    formMainMenu[formNumber] = new FormMainMenu(formLogin.LoginAccount);
                    formMainMenu[formNumber].Show();
                    this.formMainMenuClosed += QLNHApplicationContext_formMainMenuClosed;
                }
                else
                {
                    throw new Exception("exit");
                }
            }
            private void QLNHApplicationContext_formMainMenuClosed(object sender, FormClosedEventArgs e)
            {
                this.formMainMenuClosed -= QLNHApplicationContext_formMainMenuClosed;
                formNumber = (formNumber + 1) % 2;
                formLogin = new FormLogin();
                if (formLogin.ShowDialog() == DialogResult.OK)
                {
                    formMainMenu[formNumber] = new FormMainMenu(formLogin.LoginAccount);
                    formMainMenu[formNumber].Show();
                    this.formMainMenuClosed += QLNHApplicationContext_formMainMenuClosed;
                }
                else
                {
                    Application.Exit();
                }
            }

            public event FormClosedEventHandler formMainMenuClosed
            {
                add { this.formMainMenu[formNumber].FormClosed += value; }
                remove { this.formMainMenu[formNumber].FormClosed -= value; }
            }

        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMainMenu(0));
            //try
            //{
            //    Application.Run(new BPMSApplicationContext());
            //}
            //catch
            //{
            //    Application.Exit();
            //}
        }
    }
}
