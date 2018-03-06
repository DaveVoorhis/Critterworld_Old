using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CritterWorld
{
    class MessageNotifyCloseToObject : Message
    {
        VisibleObject closeToObject;

        public MessageNotifyCloseToObject(VisibleObject closeToObject) 
        {
            this.closeToObject = closeToObject;
        }

        public VisibleObject CloseToObject
        {
            get 
            { 
                return closeToObject; 
            }
        }
    }
}
