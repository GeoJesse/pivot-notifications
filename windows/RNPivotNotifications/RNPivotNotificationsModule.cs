using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Pivot.Notifications.RNPivotNotifications
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNPivotNotificationsModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNPivotNotificationsModule"/>.
        /// </summary>
        internal RNPivotNotificationsModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNPivotNotifications";
            }
        }
    }
}
