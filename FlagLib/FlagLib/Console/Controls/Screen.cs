﻿using FlagLib.Measure;

namespace FlagLib.Console.Controls
{
    /// <summary>
    /// Top container, equals the <see cref="System.Windows.Forms.Form"/> class. <para />
    /// Every control and container should be placed here
    /// </summary>
    public class Screen : Container
    {
        /// <summary>
        /// Gets the absolute position to the console.
        /// </summary>
        /// <value>The absolute position to the console.</value>
        public override Position AbsolutePosition
        {
            get { return this.RelativePosition; }
        }

        /// <summary>
        /// Gets the top control (the screen).
        /// </summary>
        /// <value>The top control.</value>
        public override Control Top
        {
            get { return this; }
        }
    }
}