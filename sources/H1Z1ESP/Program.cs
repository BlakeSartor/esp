using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Diagnostics;
using SlimDX.Direct3D9;
using SlimDX;

namespace H1Z1ESP
{   
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int X;
        public int Y;

        public POINT(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MARGIN
    {
        public int Top;
        public int Left;        
        public int Right; 
        public int Bottom;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Matrix4
    {
        public float M11;
        public float M12;
        public float M13;
        public float M14;
        public float M21;
        public float M22;
        public float M23;
        public float M24;
        public float M31;
        public float M32;
        public float M33;
        public float M34;
        public float M41;
        public float M42;
        public float M43;
        public float M44;
    }

    public class ENTITY
    {
        public Int32 Id;
        public Int32 Type;
        public String Name;        
        public Vector3 Vector;
        public Vector3 Pos;
        public Vector2 Screen;
        public Double Distance;
        public Double Pitch;
        public Double Yaw;
        public Double Speed;
    }

    #region Class: Windows API
    public class Native
    {
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int ProcessId);

        [DllImport("user32.dll", SetLastError=true)]
        public static extern uint GetWindowLong(IntPtr hWnd, int nIndex);
        
        [DllImport("user32.dll", SetLastError=true)]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError=true)]
        public static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);
        
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("dwmapi.dll")]
        public static extern void DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGIN pMargins);

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(uint dwAccess, bool inherit, int pid);

        [DllImport("kernel32.dll", SetLastError=true)]
        public static extern bool ReadProcessMemory(IntPtr hProcess, long lpBaseAddress, [In, Out] byte[] lpBuffer, ulong dwSize, out IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern bool CloseHandle(IntPtr handle);

        [DllImport("user32.dll", CallingConvention=CallingConvention.StdCall, CharSet=CharSet.Auto)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, uint cButtons, uint dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);
        
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Keys vKey);
    }
    #endregion

    public class IniHandler
    {
        public string path;

        public IniHandler(string INIPath)
        {
            this.path = INIPath;
        }

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        public string IniReadValue(string Section, string Key)
        {
            StringBuilder retVal = new StringBuilder(0xff);
            GetPrivateProfileString(Section, Key, "", retVal, 0xff, this.path);
            return retVal.ToString();
        }

        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.path);
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
    }

    
    #region Class: FastMemory
    public class FastMemory
    {
        public Process Process;
        private Int32 ProcessID;
        private IntPtr ProcessHandle;
        private String ProcessClassName;        

        ~FastMemory()
        {
            if (this.ProcessHandle != IntPtr.Zero)
            {
                Native.CloseHandle(this.ProcessHandle);
            }
        }

        public bool Attach(string lpClassName)
        {            
            this.ProcessHandle = Native.FindWindow(lpClassName, null);
            if (this.ProcessHandle != IntPtr.Zero)
            {
                this.ProcessClassName = lpClassName;
                Native.GetWindowThreadProcessId(this.ProcessHandle, out this.ProcessID);
                this.Process = Process.GetProcessById(this.ProcessID);
                this.ProcessHandle = Native.OpenProcess(0x38, false, this.ProcessID);
                return (this.ProcessHandle != IntPtr.Zero);
            }
            return false;
        }

        public bool IsOpen
        {
            get
            {
                return this.Attach(this.ProcessClassName);
            }
        }

        public byte ReadByte(long lpBaseAddress)
        {
            IntPtr ptr; byte[] lpBuffer = new byte[1];
            Native.ReadProcessMemory(this.ProcessHandle, lpBaseAddress, lpBuffer, 1L, out ptr);
            return lpBuffer[0];
        }

        public byte[] ReadBytes(long _lpBaseAddress, ulong _Size)
        {
            IntPtr ptr; byte[] lpBuffer = new byte[_Size];
            Native.ReadProcessMemory(this.ProcessHandle, _lpBaseAddress, lpBuffer, _Size, out ptr);
            return lpBuffer;
        }

        public float ReadFloat(long _lpBaseAddress)
        {
            IntPtr ptr; byte[] lpBuffer = new byte[4];
            Native.ReadProcessMemory(this.ProcessHandle, _lpBaseAddress, lpBuffer, 4L, out ptr);
            return BitConverter.ToSingle(lpBuffer, 0);
        }

        public double ReadDouble(long _lpBaseAddress)
        {
            IntPtr ptr; byte[] lpBuffer = new byte[8];
            Native.ReadProcessMemory(this.ProcessHandle, _lpBaseAddress, lpBuffer, 8L, out ptr);
            return BitConverter.ToDouble(lpBuffer, 0);
        }

        public short ReadInt16(long _lpBaseAddress)
        {
            IntPtr ptr; byte[] lpBuffer = new byte[2];
            Native.ReadProcessMemory(this.ProcessHandle, _lpBaseAddress, lpBuffer, 2L, out ptr);
            return BitConverter.ToInt16(lpBuffer, 0);
        }

        public ushort ReadUInt16(long lpBaseAddress)
        {
            IntPtr ptr; byte[] lpBuffer = new byte[2];
            Native.ReadProcessMemory(this.ProcessHandle, lpBaseAddress, lpBuffer, 2L, out ptr);
            return BitConverter.ToUInt16(lpBuffer, 0);
        }

        public int ReadInt32(long _lpBaseAddress)
        {
            IntPtr ptr; byte[] lpBuffer = new byte[4];
            Native.ReadProcessMemory(this.ProcessHandle, _lpBaseAddress, lpBuffer, 4L, out ptr);
            return BitConverter.ToInt32(lpBuffer, 0);
        }

        public uint ReadUInt32(long lpBaseAddress)
        {
            IntPtr ptr; byte[] lpBuffer = new byte[4];
            Native.ReadProcessMemory(this.ProcessHandle, lpBaseAddress, lpBuffer, 4L, out ptr);
            return BitConverter.ToUInt32(lpBuffer, 0);
        }        

        public long ReadInt64(long _lpBaseAddress)
        {
            IntPtr ptr; byte[] lpBuffer = new byte[8];
            Native.ReadProcessMemory(this.ProcessHandle, _lpBaseAddress, lpBuffer, 8L, out ptr);
            return BitConverter.ToInt64(lpBuffer, 0);
        }

        public ulong ReadUInt64(long lpBaseAddress)
        {
            IntPtr ptr; byte[] lpBuffer = new byte[8];
            Native.ReadProcessMemory(this.ProcessHandle, lpBaseAddress, lpBuffer, 8L, out ptr);
            return BitConverter.ToUInt64(lpBuffer, 0);
        }

        public Matrix4 ReadMatrix(long _lpBaseAddress)
        {
            IntPtr ptr; Matrix4 matrix = new Matrix4(); byte[] lpBuffer = new byte[0x40];
            Native.ReadProcessMemory(this.ProcessHandle, _lpBaseAddress, lpBuffer, 0x40L, out ptr);
            matrix.M11 = BitConverter.ToSingle(lpBuffer, 0x00);
            matrix.M12 = BitConverter.ToSingle(lpBuffer, 0x04);
            matrix.M13 = BitConverter.ToSingle(lpBuffer, 0x08);
            matrix.M14 = BitConverter.ToSingle(lpBuffer, 0x0C);
            matrix.M21 = BitConverter.ToSingle(lpBuffer, 0x10);
            matrix.M22 = BitConverter.ToSingle(lpBuffer, 0x14);
            matrix.M23 = BitConverter.ToSingle(lpBuffer, 0x18);
            matrix.M24 = BitConverter.ToSingle(lpBuffer, 0x1C);
            matrix.M31 = BitConverter.ToSingle(lpBuffer, 0x20);
            matrix.M32 = BitConverter.ToSingle(lpBuffer, 0x24);
            matrix.M33 = BitConverter.ToSingle(lpBuffer, 0x28);
            matrix.M34 = BitConverter.ToSingle(lpBuffer, 0x2C);
            matrix.M41 = BitConverter.ToSingle(lpBuffer, 0x30);
            matrix.M42 = BitConverter.ToSingle(lpBuffer, 0x34);
            matrix.M43 = BitConverter.ToSingle(lpBuffer, 0x38);
            matrix.M44 = BitConverter.ToSingle(lpBuffer, 0x3C);
            return matrix;
        }

        public string ReadString(long lpBaseAddress, int size)
        {
            IntPtr ptr; byte[] lpBuffer = new byte[size];
            Native.ReadProcessMemory(this.ProcessHandle, lpBaseAddress, lpBuffer, (ulong)size, out ptr);
            return Encoding.UTF8.GetString(lpBuffer);
        }        
    }
    #endregion

    #region Class: Hotkey
    public class Hotkey
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [Flags]
        public enum Modifiers
        {
            Alt = 1,
            Ctrl = 2,
            None = 0,
            Shift = 4,
            Win = 8
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct HookInfo
        {
            public int ID;
            public IntPtr hWnd;
            public HookInfo(IntPtr Handle, int id)
            {
                this.ID = id;
                this.hWnd = Handle;
            }
        }

        private int freeID = 0;
        private List<HookInfo> hookedKeys = new List<HookInfo>();
        public const int WM_HOTKEY_MSG_ID = 0x312;

        public void disable(HookInfo i)
        {
            this.RemoveHook(i);
            UnregisterHotKey(i.hWnd, i.ID);
        }

        public HookInfo enable(IntPtr Handle, Modifiers Mod, Keys Key)
        {
            HookInfo item = new HookInfo(Handle, this.freeID++);
            this.hookedKeys.Add(item);
            RegisterHotKey(Handle, item.ID, (int)Mod, (int)Key);
            return item;
        }

        ~Hotkey()
        {
            this.unhookAll();
        }
        
        private void RemoveHook(HookInfo hInfo)
        {
            for (int i = 0; i < this.hookedKeys.Count; i++)
            {
                if ((this.hookedKeys[i].hWnd == hInfo.hWnd) && (this.hookedKeys[i].ID == hInfo.ID))
                {
                    this.hookedKeys.RemoveAt(i--);
                }
            }
        }

        public void unhookAll()
        {
            for (int i = 0; i < this.hookedKeys.Count; i++)
            {
                this.disable(this.hookedKeys[i]);
            }
        }
        
        public HookInfo[] HookedKeys
        {
            get
            {
                return this.hookedKeys.ToArray();
            }
        }
    }    
    #endregion

    public static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
