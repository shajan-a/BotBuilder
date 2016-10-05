﻿using System;
using System.Linq;

namespace Microsoft.Bot.Connector
{
    /// <summary>
    /// Activity generated by external sources with open ended value payload
    /// </summary>
    public interface ITriggerActivity : IActivity
    {
        /// <summary>
        /// Open ended value 
        /// </summary>
        object Value { get; set; }
    }
}
