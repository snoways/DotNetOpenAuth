﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3521
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetOpenAuth.OpenId {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class OpenIdStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal OpenIdStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotNetOpenAuth.OpenId.OpenIdStrings", typeof(OpenIdStrings).Assembly);
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
        ///   Looks up a localized string similar to The association and nonce stores must either be both null or both non-null..
        /// </summary>
        internal static string AssociationAndNonceStoresMustBeBothNullOrBothNonNull {
            get {
                return ResourceManager.GetString("AssociationAndNonceStoresMustBeBothNullOrBothNonNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The length of the shared secret ({0}) does not match the length required by the association type (&apos;{1}&apos;)..
        /// </summary>
        internal static string AssociationSecretAndTypeLengthMismatch {
            get {
                return ResourceManager.GetString("AssociationSecretAndTypeLengthMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The length of the encrypted shared secret ({0}) does not match the length of the hashing algorithm ({1})..
        /// </summary>
        internal static string AssociationSecretHashLengthMismatch {
            get {
                return ResourceManager.GetString("AssociationSecretHashLengthMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The private data supplied does not meet the requirements of any known Association type.  Its length may be too short, or it may have been corrupted..
        /// </summary>
        internal static string BadAssociationPrivateData {
            get {
                return ResourceManager.GetString("BadAssociationPrivateData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A Simple Registration request can only generate a response on the receiving end..
        /// </summary>
        internal static string CallDeserializeBeforeCreateResponse {
            get {
                return ResourceManager.GetString("CallDeserializeBeforeCreateResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The openid.claimed_id and openid.identity parameters must both be present or both be absent..
        /// </summary>
        internal static string ClaimedIdAndLocalIdMustBothPresentOrAbsent {
            get {
                return ResourceManager.GetString("ClaimedIdAndLocalIdMustBothPresentOrAbsent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following properties must be set before the Diffie-Hellman algorithm can generate a public key: {0}.
        /// </summary>
        internal static string DiffieHellmanRequiredPropertiesNotSet {
            get {
                return ResourceManager.GetString("DiffieHellmanRequiredPropertiesNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to URI is not SSL yet requireSslDiscovery is set to true..
        /// </summary>
        internal static string ExplicitHttpUriSuppliedWithSslRequirement {
            get {
                return ResourceManager.GetString("ExplicitHttpUriSuppliedWithSslRequirement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An extension sharing namespace &apos;{0}&apos; has already been added.  Only one extension per namespace is allowed in a given request..
        /// </summary>
        internal static string ExtensionAlreadyAddedWithSameTypeURI {
            get {
                return ResourceManager.GetString("ExtensionAlreadyAddedWithSameTypeURI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot encode &apos;{0}&apos; because it contains an illegal character for Key-Value Form encoding.  (line {1}: &apos;{2}&apos;).
        /// </summary>
        internal static string InvalidCharacterInKeyValueFormInput {
            get {
                return ResourceManager.GetString("InvalidCharacterInKeyValueFormInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot decode Key-Value Form because a line was found without a &apos;{0}&apos; character.  (line {1}: &apos;{2}&apos;).
        /// </summary>
        internal static string InvalidKeyValueFormCharacterMissing {
            get {
                return ResourceManager.GetString("InvalidKeyValueFormCharacterMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The scheme must be http or https but was &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidScheme {
            get {
                return ResourceManager.GetString("InvalidScheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; is not a valid URI..
        /// </summary>
        internal static string InvalidUri {
            get {
                return ResourceManager.GetString("InvalidUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not a recognized XRI format: &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidXri {
            get {
                return ResourceManager.GetString("InvalidXri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The list of keys do not match the provided dictionary..
        /// </summary>
        internal static string KeysListAndDictionaryDoNotMatch {
            get {
                return ResourceManager.GetString("KeysListAndDictionaryDoNotMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No recognized association type matches the requested length of {0}..
        /// </summary>
        internal static string NoAssociationTypeFoundByLength {
            get {
                return ResourceManager.GetString("NoAssociationTypeFoundByLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No recognized association type matches the requested name of &apos;{0}&apos;..
        /// </summary>
        internal static string NoAssociationTypeFoundByName {
            get {
                return ResourceManager.GetString("NoAssociationTypeFoundByName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unless using transport layer encryption, &quot;no-encryption&quot; MUST NOT be used..
        /// </summary>
        internal static string NoEncryptionSessionRequiresHttps {
            get {
                return ResourceManager.GetString("NoEncryptionSessionRequiresHttps", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Diffie-Hellman session type &apos;{0}&apos; not found for OpenID {1}..
        /// </summary>
        internal static string NoSessionTypeFound {
            get {
                return ResourceManager.GetString("NoSessionTypeFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No OpenId endpoint found..
        /// </summary>
        internal static string OpenIdEndpointNotFound {
            get {
                return ResourceManager.GetString("OpenIdEndpointNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to determine the version of the OpenID protocol implemented by the Provider at endpoint &apos;{0}&apos;..
        /// </summary>
        internal static string ProviderVersionUnrecognized {
            get {
                return ResourceManager.GetString("ProviderVersionUnrecognized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An HTTP request to the realm URL ({0}) resulted in a redirect, which is not allowed during relying party discovery..
        /// </summary>
        internal static string RealmCausedRedirectUponDiscovery {
            get {
                return ResourceManager.GetString("RealmCausedRedirectUponDiscovery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to return_to &apos;{0}&apos; not under realm &apos;{1}&apos;..
        /// </summary>
        internal static string ReturnToNotUnderRealm {
            get {
                return ResourceManager.GetString("ReturnToNotUnderRealm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} parameter ({1}) does not match the actual URL ({2}) the request was made with..
        /// </summary>
        internal static string ReturnToParamDoesNotMatchRequestUrl {
            get {
                return ResourceManager.GetString("ReturnToParamDoesNotMatchRequestUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The openid.return_to parameter is required in the request message in order to construct a response, but that parameter was missing..
        /// </summary>
        internal static string ReturnToRequiredForResponse {
            get {
                return ResourceManager.GetString("ReturnToRequiredForResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following parameter(s) are not included in the signature but must be: {0}.
        /// </summary>
        internal static string SignatureDoesNotIncludeMandatoryParts {
            get {
                return ResourceManager.GetString("SignatureDoesNotIncludeMandatoryParts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid birthdate value.  Must be in the form yyyy-MM-dd..
        /// </summary>
        internal static string SregInvalidBirthdate {
            get {
                return ResourceManager.GetString("SregInvalidBirthdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type must implement {0}..
        /// </summary>
        internal static string TypeMustImplementX {
            get {
                return ResourceManager.GetString("TypeMustImplementX", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsolicited assertions are not allowed from 1.0 OpenID Providers..
        /// </summary>
        internal static string UnsolicitedAssertionsNotAllowedFrom1xOPs {
            get {
                return ResourceManager.GetString("UnsolicitedAssertionsNotAllowedFrom1xOPs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The openid.user_setup_url parameter is required when sending negative assertion messages in response to immediate mode requests..
        /// </summary>
        internal static string UserSetupUrlRequiredInImmediateNegativeResponse {
            get {
                return ResourceManager.GetString("UserSetupUrlRequiredInImmediateNegativeResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to XRI resolution failed..
        /// </summary>
        internal static string XriResolutionFailed {
            get {
                return ResourceManager.GetString("XriResolutionFailed", resourceCulture);
            }
        }
    }
}
