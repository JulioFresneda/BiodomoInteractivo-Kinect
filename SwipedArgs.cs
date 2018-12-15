using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Samples.Kinect.ControlsBasics
{
    class SwipedArgs : EventArgs
    {
        private string SwipeType;

        public string GestureType
        {
            get { return this.SwipeType; }
            set { this.SwipeType = value; }
        }
    }
}
