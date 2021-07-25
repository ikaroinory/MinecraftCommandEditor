using System;
using System.Drawing;                                           // Point.Point()
using System.Runtime.InteropServices;                           // DllImport
using System.Text;
using System.Windows.Forms;

namespace ExMessageBox
{
    public class MsgBox
    {
        /// <summary>
        /// 显示一个具有指定文本、标题、按钮、图标、默认按钮、选项和“帮助”按钮的消息框。
        /// </summary>
        /// <param name="text">要在消息框中显示的文本。</param>
        /// <param name="caption">要在消息框的标题栏中显示的文本。</param>
        /// <param name="buttons">System.Windows.Forms.MessageBoxButtons 值之一，可指定在消息框中显示哪些按钮。</param>
        /// <param name="buttonTitles">将一个字符串类型的数组中的元素设置给按钮。</param>
        /// <returns>System.Windows.Forms.DialogResult 值之一。</returns>
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, string[] buttonTitles)
        {
            MessageForm frm = new MessageForm(buttons, buttonTitles);
            frm.Show();
            frm.WatchForActivate = true;
            DialogResult result = MessageBox.Show(frm, text, caption, buttons);
            frm.Close();

            return result;
        }

        /// <summary>
        /// 显示一个具有指定文本、标题、按钮、图标、默认按钮、选项和“帮助”按钮的消息框。
        /// </summary>
        /// <param name="text">要在消息框中显示的文本。</param>
        /// <param name="caption">要在消息框的标题栏中显示的文本。</param>
        /// <param name="buttons">System.Windows.Forms.MessageBoxButtons 值之一，可指定在消息框中显示哪些按钮。</param>
        /// <param name="icon">System.Windows.Forms.MessageBoxIcon 值之一，它指定在消息框中显示哪个图标。</param>
        /// <param name="defaultButton"></param>
        /// <param name="buttonTitles">将一个字符串类型的数组中的元素设置给按钮。</param>
        /// <returns>System.Windows.Forms.DialogResult 值之一。</returns>
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons,
            MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, string[] buttonTitles)
        {
            MessageForm frm = new MessageForm(buttons, buttonTitles);
            frm.Show();
            frm.WatchForActivate = true;
            DialogResult result = MessageBox.Show(frm, text, caption, buttons, icon, defaultButton);
            frm.Close();

            return result;
        }

        class MessageForm : Form
        {
            IntPtr _handle;
            MessageBoxButtons _buttons;
            string[] _buttonTitles = null;

            bool _watchForActivate = false;

            public bool WatchForActivate
            {
                get { return _watchForActivate; }
                set { _watchForActivate = value; }
            }

            public MessageForm(MessageBoxButtons buttons, string[] buttonTitles)
            {
                _buttons = buttons;
                _buttonTitles = buttonTitles;

                // Hide self form, and don't show self form in task bar.
                this.Text = "";
                this.StartPosition = FormStartPosition.CenterScreen;
                this.Location = new Point(-32000, -32000);
                this.ShowInTaskbar = false;
            }

            protected override void OnShown(EventArgs e)
            {
                base.OnShown(e);
                // Hide self form, don't show self form even in task list.
                NativeWin32API.SetWindowPos(this.Handle, IntPtr.Zero, 0, 0, 0, 0, 659);
            }

            protected override void WndProc(ref System.Windows.Forms.Message m)
            {
                if (_watchForActivate && m.Msg == 0x0006)
                {
                    _watchForActivate = false;
                    _handle = m.LParam;
                    CheckMsgbox();
                }
                base.WndProc(ref m);
            }

            private void CheckMsgbox()
            {
                if (_buttonTitles == null || _buttonTitles.Length == 0)
                    return;

                // Button title index
                int buttonTitleIndex = 0;
                // Get the handle of control in current window.
                IntPtr h = NativeWin32API.GetWindow(_handle, GW_CHILD);

                // Set those custom titles to the three buttons(Default title are: Yes, No and Cancle).
                while (h != IntPtr.Zero)
                {
                    if (NativeWin32API.GetWindowClassName(h).Equals("Button"))
                    {
                        if (_buttonTitles.Length > buttonTitleIndex)
                        {
                            // Changes the text of the specified window's title bar (if it has one). 
                            // If the specified window is a control, the text of the control is changed. 
                            // However, SetWindowText cannot change the text of a control in another application.
                            NativeWin32API.SetWindowText(h, _buttonTitles[buttonTitleIndex]);

                            buttonTitleIndex++;
                        }
                    }

                    // Get the handle of next control in current window.
                    h = NativeWin32API.GetWindow(h, GW_HWNDNEXT);
                }
            }
        }


        public const int GW_CHILD = 5;
        public const int GW_HWNDNEXT = 2;

        public class NativeWin32API
        {
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int Width, int Height, int flags);
            [DllImport("user32.dll")]
            public static extern IntPtr GetWindow(IntPtr hWnd, Int32 wCmd);
            [DllImport("user32.dll")]
            public static extern bool SetWindowText(IntPtr hWnd, string lpString);
            [DllImport("user32.dll")]
            public static extern int GetClassNameW(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpString, int nMaxCount);

            public static string GetWindowClassName(IntPtr handle)
            {
                StringBuilder sb = new StringBuilder(256);

                // Retrieves the name of the class to which the specified window belongs
                GetClassNameW(handle, sb, sb.Capacity);
                return sb.ToString();
            }
        }
    }
}
