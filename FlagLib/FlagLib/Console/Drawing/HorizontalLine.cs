﻿using System;
using FlagLib.Measure;

namespace FlagLib.Console.Drawing
{
    /// <summary>
    /// Represents a horizontal line
    /// </summary>
    public class HorizontalLine : Line
    {
        /// <summary>
        /// Draws the line.
        /// </summary>
        public override void Draw()
        {
            ConsoleColor saveForeColor = System.Console.ForegroundColor;
            ConsoleColor saveBackColor = System.Console.BackgroundColor;

            System.Console.ForegroundColor = this.ForegroundColor;
            System.Console.BackgroundColor = this.BackgroundColor;

            string line = "";

            for (int i = 0; i < this.Length; i++)
            {
                line += this.Token.ToString();
            }

            System.Console.SetCursorPosition(this.Position.X, this.Position.Y);
            System.Console.Write(line);

            System.Console.ForegroundColor = saveForeColor;
            System.Console.BackgroundColor = saveBackColor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HorizontalLine"/> class.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="length">The lenght.</param>
        /// <param name="token">The token.</param>
        public HorizontalLine(Position position, int length, char token)
            : base(position, length, token)
        {
        }
    }
}