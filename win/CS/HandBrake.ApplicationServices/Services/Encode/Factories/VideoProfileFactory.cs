﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VideoProfileFactory.cs" company="HandBrake Project (http://handbrake.fr)">
//   This file is part of the HandBrake source code - It may be used under the terms of the GNU General Public License.
// </copyright>
// <summary>
//   The video profile factory.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace HandBrake.ApplicationServices.Services.Encode.Factories
{
    /// <summary>
    /// The video profile factory.
    /// </summary>
    public class VideoProfileFactory
    {
        /// <summary>
        /// The get display name for a given short name.
        /// LibHB doesn't currently support this.
        /// </summary>
        /// <param name="shortName">
        /// The short name.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string GetDisplayName(string shortName)
        {
            switch (shortName)
            {
                case "auto":
                    return "Auto";
                case "main":
                    return "Main";
                case "high":
                    return "High";
                case "baseline":
                    return "Baseline";
            }

            return shortName;
        }
    }
}
