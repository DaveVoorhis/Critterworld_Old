using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CritterWorld
{
    class MessageNotifyBumped : Message
    {
        VisibleObject bumpedObject;

        public MessageNotifyBumped(VisibleObject bumpedObject) 
        {
            this.bumpedObject = bumpedObject;
        }

        public VisibleObject BumpedObject
        {
            get 
            { 
                return bumpedObject; 
            }
        }
    }
}
