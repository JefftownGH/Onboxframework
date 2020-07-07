﻿using System;

namespace Onbox.Revit.V7
{
    /// <summary>
    /// Revit Application version, name, language and window handle
    /// </summary>
    public interface IRevitAppData
    {
        /// <summary>
        /// Revit's build version
        /// </summary>
        string GetVersionBuild();

        /// <summary>
        /// Revit's version name
        /// </summary>
        string GetVersionName();

        /// <summary>
        /// Revit's version number
        /// </summary>
        string GetVersionNumber();

        /// <summary>
        /// Revit's build version name
        /// </summary>
        string GetSubVersionNumber();

        /// <summary>
        /// Revit's language
        /// </summary>
        RevitLanguage GetLanguage();

        /// <summary>
        /// Revit's window handler pointer
        /// </summary>
        IntPtr GetRevitWindowHandle();

        /// <summary>
        /// Flag to tell if revit was lanched in Viewer mode
        /// </summary>
        bool GetIsViewerMode();
    }
}