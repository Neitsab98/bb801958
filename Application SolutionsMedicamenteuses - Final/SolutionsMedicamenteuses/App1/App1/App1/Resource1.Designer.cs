﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App1 {
    using System;
    
    
    /// <summary>
    ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    /// </summary>
    // Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    // à l'aide d'un outil, tel que ResGen ou Visual Studio.
    // Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    // avec l'option /str ou régénérez votre projet VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("App1.Resource1", typeof(Resource1).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Remplace la propriété CurrentUICulture du thread actuel pour toutes
        ///   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;tableau&gt;
        ///	&lt;solution id=&quot;s1&quot;&gt;
        ///		&lt;nom&gt;Exacyl&lt;/nom&gt;
        ///		&lt;molecule&gt;Acide Tranexamique&lt;/molecule&gt;
        ///		&lt;solvant&gt;SPHI&lt;/solvant&gt;
        ///		&lt;qteProduit&gt;5&lt;/qteProduit&gt;
        ///    &lt;uniteProduit&gt;ml&lt;/uniteProduit&gt;
        ///    &lt;uniteSolution&gt;ml&lt;/uniteSolution&gt;
        ///		&lt;qteSolvant&gt;45&lt;/qteSolvant&gt;
        ///		&lt;dosePoids1&gt;4&lt;/dosePoids1&gt;
        ///		&lt;dosePoids2&gt;5&lt;/dosePoids2&gt;
        ///		&lt;dosePoids3&gt;6&lt;/dosePoids3&gt;
        ///		&lt;dosePoids4&gt;7&lt;/dosePoids4&gt;
        ///		&lt;infoSup&gt;Choc hémorragique&lt;/infoSup&gt;
        ///	&lt;/solution&gt;
        ///	&lt;solution  id=&quot;s2&quot;&gt;
        ///		&lt;nom&gt;Krenosin&lt; [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        public static string testDB {
            get {
                return ResourceManager.GetString("testDB", resourceCulture);
            }
        }
    }
}
