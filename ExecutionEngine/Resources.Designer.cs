﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VisualStudio.Macros.ExecutionEngine
{


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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VisualStudio.Macros.ExecutionEngine.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Command not valid in this context.
        /// </summary>
        internal static string CommandNotValid {
            get {
                return ResourceManager.GetString("CommandNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The PID argument is invalid..
        /// </summary>
        internal static string InvalidPIDArgument {
            get {
                return ResourceManager.GetString("InvalidPIDArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Requires a document to be open..
        /// </summary>
        internal static string NoActiveDocumentErrorMessage {
            get {
                return ResourceManager.GetString("NoActiveDocumentErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Engine.CommandHelper is null..
        /// </summary>
        internal static string NullCommandHelper {
            get {
                return ResourceManager.GetString("NullCommandHelper", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The dispatch object was null..
        /// </summary>
        internal static string NullDispatch {
            get {
                return ResourceManager.GetString("NullDispatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Engine.DteObject is null..
        /// </summary>
        internal static string NullDte {
            get {
                return ResourceManager.GetString("NullDte", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} does not support this property or method..
        /// </summary>
        internal static string ObjectDoesNotSupportMethod {
            get {
                return ResourceManager.GetString("ObjectDoesNotSupportMethod", resourceCulture);
            }
        }
    }
}