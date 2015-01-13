using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using EasyHook;

namespace HelloDXOverlay
{
    public class HookInterface : MarshalByRefObject
    {
        public enum Hookstatus
        {
            Hooked,
            Disconnected
        }
        
        public delegate void Messages(string text);
        public delegate void Hookchange(Hookstatus status);
        public event Messages onMessage;
        public event Hookchange onHookstatusChange;
        private string _overlaytext;
        private Color _colour;
        private int _overlaysize;

        public int OverlaySize
        {
            get { return _overlaysize; }
            set { _overlaysize = value; }
        }
        

        public Color Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }
        
        

        public string OverlayText
        {
            get { return _overlaytext; }
            set { _overlaytext = value; }
        }
        

        public void ChangeHookStatus(Hookstatus status)
        {
            if (onHookstatusChange != null) {
                onHookstatusChange(status);
            }
        }

        public void Text(string text)
        {
            if (onMessage != null) {
                onMessage(text);
            }
        }

    }
}
