using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Belly.Dance.Exhibition.Center.RNBellyDanceExhibitionCenter
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNBellyDanceExhibitionCenterModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNBellyDanceExhibitionCenterModule"/>.
        /// </summary>
        internal RNBellyDanceExhibitionCenterModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNBellyDanceExhibitionCenter";
            }
        }
    }
}
