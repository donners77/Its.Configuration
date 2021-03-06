// Copyright (c) Microsoft. All rights reserved. 
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Its.Configuration
{
    /// <summary>
    ///     Provides access to settings.
    /// </summary>
    public interface ISettingsSource
    {
        /// <summary>
        ///     Gets a settings string corresponding to the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>A string representing serialized settings.</returns>
        string GetSerializedSetting(string key);

        /// <summary>
        ///     Gets the name of the settings source.
        /// </summary>
        string Name { get; }
    }
}