﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace GrapeCity.ActiveReports.Samples.CreateReport.Properties {
    using System;
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        private static global::System.Resources.ResourceManager resourceMan;
        private static global::System.Globalization.CultureInfo resourceCulture;
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GrapeCity.ActiveReports.Samples.CreateReport.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon arLogo_32 {
            get {
                object obj = ResourceManager.GetObject("arLogo_32", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap CmdNewReport {
            get {
                object obj = ResourceManager.GetObject("CmdNewReport", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap CmdOpen {
            get {
                object obj = ResourceManager.GetObject("CmdOpen", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap CmdSave {
            get {
                object obj = ResourceManager.GetObject("CmdSave", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap CmdSaveAs {
            get {
                object obj = ResourceManager.GetObject("CmdSaveAs", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        /// <summary>
        ///   Looks up a localized string similar to Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=C:\\Users\\evan.warren\\Documents\\GrapeCity Samples\\ActiveReports 11\\Data\\Reels.mdb.
        /// </summary>
        internal static string ConnectionString {
            get {
                return ResourceManager.GetString("ConnectionString", resourceCulture);
            }
        }
        /// <summary>
        ///   Looks up a localized string similar to New.
        /// </summary>
        internal static string New {
            get {
                return ResourceManager.GetString("New", resourceCulture);
            }
        }
    }
}
