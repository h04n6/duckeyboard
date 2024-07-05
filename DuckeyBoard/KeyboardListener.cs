using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Reflection;

namespace DuckeyBoard
{
    /// <summary>
    /// Listens keyboard globally.
    /// 
    /// <remarks>Uses WH_KEYBOARD_LL.</remarks>
    /// </summary>
    public class KeyboardListener
    {
        #region Win32 API Functions and Constants

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, KeyboardHookDelegate lpfn, IntPtr hMod, int dwThreadId);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private const int WH_KEYBOARD_LL = 13;

        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x101;
        private const int WM_UNICHAR = 0x0109;
        private const int WM_CHAR = 0x0102;

        #endregion

        private KeyboardHookDelegate _hookProc;
        private IntPtr _hookHandle = IntPtr.Zero;

        public delegate IntPtr KeyboardHookDelegate(int nCode, IntPtr wParam, IntPtr lParam);

        [StructLayout(LayoutKind.Sequential)]
        public struct KeyboardHookStruct
        {
            public int VirtualKeyCode;
            public int ScanCode;
            public int Flags;
            public int Time;
            public int ExtraInfo;
        }

        #region Keyboard Events

        public event KeyEventHandler KeyDown;
        public event KeyEventHandler KeyUp;

        #endregion

        // destructor
        ~KeyboardListener()
        {
            Uninstall();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Win32Exception"></exception>
        public void Install()
        {
            _hookProc = KeyboardHookProc;
            _hookHandle = SetupHook(_hookProc);

            if (_hookHandle == IntPtr.Zero)
                throw new Win32Exception(Marshal.GetLastWin32Error());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hookProc"></param>
        /// <returns></returns>
        private IntPtr SetupHook(KeyboardHookDelegate hookProc)
        {
            // IntPtr = Int Pointer. Giá trị của con trỏ (pointer) chính là địa chỉ đang trỏ tới.
            // HINSTANCE = instance handle
            IntPtr hInstance = Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]);

            return SetWindowsHookEx(WH_KEYBOARD_LL, hookProc, hInstance, 0);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        private IntPtr KeyboardHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                KeyboardHookStruct kbStruct = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));

                // if (wParam == (IntPtr)WM_KEYDOWN)
                if (wParam == (IntPtr)WM_KEYDOWN)
                {
                    if (KeyDown != null)
                        KeyDown(null, new KeyEventArgs((Keys)kbStruct.VirtualKeyCode));
                }
                else if (wParam == (IntPtr)WM_KEYUP)
                {
                    if (KeyUp != null)
                        KeyUp(null, new KeyEventArgs((Keys)kbStruct.VirtualKeyCode));
                }
            }

            return CallNextHookEx(_hookHandle, nCode, wParam, lParam);
        }

        public void Uninstall()
        {
            UnhookWindowsHookEx(_hookHandle);
        }
    }
}
