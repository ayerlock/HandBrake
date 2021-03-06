﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DestGeometry.cs" company="HandBrake Project (http://handbrake.fr)">
//   This file is part of the HandBrake source code - It may be used under the terms of the GNU General Public License.
// </copyright>
// <summary>
//   The dest geometry.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace HandBrake.Interop.Json.Anamorphic
{
    using System.Collections.Generic;

    /// <summary>
    /// The dest geometry.
    /// </summary>
    internal class DestSettings
    {
        public DestSettings()
        {
            this.Geometry = new Geometry();
        }

        /// <summary>
        /// Gets or sets the anamorphic mode.
        /// </summary>
        public int AnamorphicMode { get; set; }

        /// <summary>
        /// Gets or sets the crop.
        /// </summary>
        public List<int> Crop { get; set; }

        /// <summary>
        /// Gets or sets the Geometry
        /// </summary>
        public Geometry Geometry { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether itu par.
        /// </summary>
        public bool ItuPAR { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether keep display aspect.
        /// </summary>
        public int Keep { get; set; }

        /// <summary>
        /// Gets or sets the max height.
        /// </summary>
        public int MaxHeight { get; set; }

        /// <summary>
        /// Gets or sets the max width.
        /// </summary>
        public int MaxWidth { get; set; }

        /// <summary>
        /// Gets or sets the modulus.
        /// </summary>
        public int Modulus { get; set; }
    }
}