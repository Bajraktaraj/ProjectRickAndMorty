namespace ProjectRickAndMorty.Resources {
    using System;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
       
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ProjectRickAndMorty.Resources.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        
        public static string Alive {
            get {
                return ResourceManager.GetString("Alive", resourceCulture);
            }
        }
        
      
        public static string All {
            get {
                return ResourceManager.GetString("All", resourceCulture);
            }
        }
        
        
        public static string Dead {
            get {
                return ResourceManager.GetString("Dead", resourceCulture);
            }
        }
        
       
        public static string Filter {
            get {
                return ResourceManager.GetString("Filter", resourceCulture);
            }
        }
        
         localized string similar to Home.
       
        public static string Home {
            get {
                return ResourceManager.GetString("Home", resourceCulture);
            }
        }
        
        public static string Name {
            get {
                return ResourceManager.GetString("Name", resourceCulture);
            }
        }
        
        public static string Origin {
            get {
                return ResourceManager.GetString("Origin", resourceCulture);
            }
        }
        
        public static string Privacy {
            get {
                return ResourceManager.GetString("Privacy", resourceCulture);
            }
        }
        
        public static string SortBy {
            get {
                return ResourceManager.GetString("SortBy", resourceCulture);
            }
        }
        
        public static string Species {
            get {
                return ResourceManager.GetString("Species", resourceCulture);
            }
        }
        
        public static string SpeciesGender {
            get {
                return ResourceManager.GetString("SpeciesGender", resourceCulture);
            }
        }
        
        public static string Status {
            get {
                return ResourceManager.GetString("Status", resourceCulture);
            }
        }
        
        public static string Unknown {
            get {
                return ResourceManager.GetString("Unknown", resourceCulture);
            }
        }
    }
}
