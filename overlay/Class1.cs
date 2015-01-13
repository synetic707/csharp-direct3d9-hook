using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyHook;
using SharpDX;
using SharpDX.Direct3D9;
using HelloDXOverlay;
using System.Runtime.InteropServices;

namespace overlay
{
    public class Main : IEntryPoint
    {

        HelloDXOverlay.HookInterface _interface;

        public Main(RemoteHooking.IContext InContext, String InChannelName)
        {
            _interface = EasyHook.RemoteHooking.IpcConnectClient<HookInterface>(InChannelName);
            _interface.Text("DLL Linked");
            

        }



        public void Run(RemoteHooking.IContext InContext, String InChannelName)
        {
            init();
            while (true) { }
        }

        List<IntPtr> devicefunctionaddresses = new List<IntPtr>();
        LocalHook EndSceneHooker;
        public Device deviceGlobal;
        public void init()
        {
            devicefunctionaddresses = new List<IntPtr>();

            using (Direct3D d3d = new Direct3D()) {
                using (var renderform = new System.Windows.Forms.Form()) {
                    using (deviceGlobal = new Device(d3d, 0, DeviceType.NullReference, IntPtr.Zero, CreateFlags.HardwareVertexProcessing, new PresentParameters() { BackBufferWidth = 1, BackBufferHeight = 1, DeviceWindowHandle = renderform.Handle })) {
                        devicefunctionaddresses.AddRange(GetVTblAddresses(deviceGlobal.NativePointer, 119));
                    }
                }
            }

            _interface.Text("Hooking Endscene();");

            EndSceneHooker = LocalHook.Create(devicefunctionaddresses[(int)d3d9_indexes.Direct3DDevice9FunctionOrdinals.EndScene], new EndSceneDelegate(EndSceneHook), this);
            EndSceneHooker.ThreadACL.SetExclusiveACL(new Int32[1]);
            _interface.ChangeHookStatus(HookInterface.Hookstatus.Hooked);
        }

        int EndSceneHook(IntPtr device)
        {
            
            Device dev = (Device)device;
            Text(dev, _interface.OverlayText);
            
            dev.EndScene();
            return SharpDX.Result.Ok.Code;
        }

        public void Text(Device device, string hook)
        {
            try {
                using (Font font = new Font(device, new FontDescription()
                {
                    Height = _interface.OverlaySize,
                    FaceName = "Arial",
                    Italic = false,
                    Width = 0,
                    MipLevels = 1,
                    CharacterSet = FontCharacterSet.Default,
                    OutputPrecision = FontPrecision.Default,
                    Quality = FontQuality.ClearTypeNatural,
                    PitchAndFamily = FontPitchAndFamily.Default | FontPitchAndFamily.DontCare,
                    Weight = FontWeight.Bold              
                })) {
                    font.DrawText(null, hook, 0, 0, new ColorBGRA(_interface.Colour.R, _interface.Colour.G, _interface.Colour.B, 255));
                }
            } catch (Exception ex) {
                _interface.Text("Error: " + ex.Message + "\r\n");
            }
        }

        protected IntPtr[] GetVTblAddresses(IntPtr pointer, int numberOfMethods)
        {
            List<IntPtr> vtblAddresses = new List<IntPtr>();
            IntPtr vTable = Marshal.ReadIntPtr(pointer);
            for (int i = 0; i < numberOfMethods; i++)
                vtblAddresses.Add(Marshal.ReadIntPtr(vTable, i * IntPtr.Size));
            return vtblAddresses.ToArray();
        }

        [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        delegate int EndSceneDelegate(IntPtr device);
    }
}
