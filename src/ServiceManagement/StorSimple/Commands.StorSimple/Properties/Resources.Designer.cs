﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Commands.StorSimple.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.WindowsAzure.Commands.StorSimple.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to More backups are available for your query. To access the next page of your result use \&quot;-First {0} -Skip {1}\&quot; in your commandlet.
        /// </summary>
        internal static string BackupNextPageFormatMessage {
            get {
                return ResourceManager.GetString("BackupNextPageFormatMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More backups are available in the subsequent pages for your query. To access the next page use \&quot;-Skip {0}\&quot;  in your commandlet.
        /// </summary>
        internal static string BackupNextPagewithNoFirstMessage {
            get {
                return ResourceManager.GetString("BackupNextPagewithNoFirstMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No more backup sets are present for your query!.
        /// </summary>
        internal static string BackupNoMorePagesMessage {
            get {
                return ResourceManager.GetString("BackupNoMorePagesMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BackupPolicy with id {0} found!.
        /// </summary>
        internal static string BackupPolicyFound {
            get {
                return ResourceManager.GetString("BackupPolicyFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} backup polic{1} found!.
        /// </summary>
        internal static string BackupPolicyGet_StatusMessage {
            get {
                return ResourceManager.GetString("BackupPolicyGet_StatusMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} backups found!.
        /// </summary>
        internal static string BackupsReturnedCount {
            get {
                return ResourceManager.GetString("BackupsReturnedCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ClientRequestId: {0}.
        /// </summary>
        internal static string ClientRequestIdMessage {
            get {
                return ResourceManager.GetString("ClientRequestIdMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Call to service failed with error code: {0}.
        /// </summary>
        internal static string CloudExceptionMessage {
            get {
                return ResourceManager.GetString("CloudExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} StorSimple device{1} found!.
        /// </summary>
        internal static string DeviceGet_StatusMessage {
            get {
                return ResourceManager.GetString("DeviceGet_StatusMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Device with device name {0} not found under resource {1}.
        /// </summary>
        internal static string DeviceWithNameNotFoundInResourceMessage {
            get {
                return ResourceManager.GetString("DeviceWithNameNotFoundInResourceMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encryption in progress....
        /// </summary>
        internal static string EncryptionInProgressMessage {
            get {
                return ResourceManager.GetString("EncryptionInProgressMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} operation failed, please check the job status for more details..
        /// </summary>
        internal static string FailureMessageCompleteJob {
            get {
                return ResourceManager.GetString("FailureMessageCompleteJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} job failed to submit. .
        /// </summary>
        internal static string FailureMessageSubmitJob {
            get {
                return ResourceManager.GetString("FailureMessageSubmitJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter First cannot be &lt;0.
        /// </summary>
        internal static string FirstParameterInvalidMessage {
            get {
                return ResourceManager.GetString("FirstParameterInvalidMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Volume container with name: {0} is found..
        /// </summary>
        internal static string FoundDataContainerMessage {
            get {
                return ResourceManager.GetString("FoundDataContainerMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Volume with name: {0} is found..
        /// </summary>
        internal static string FoundVolumeMessage {
            get {
                return ResourceManager.GetString("FoundVolumeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Registration key specified appears to be in an incorrect format. Please verify that the exact key is copied from the portal!.
        /// </summary>
        internal static string IncorrectFormatInRegistrationKey {
            get {
                return ResourceManager.GetString("IncorrectFormatInRegistrationKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating StorageAccountCredential inline.
        /// </summary>
        internal static string InlineSacCreationMessage {
            get {
                return ResourceManager.GetString("InlineSacCreationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify valid string for BackupId parameter.
        /// </summary>
        internal static string InvalidBackupIdParameter {
            get {
                return ResourceManager.GetString("InvalidBackupIdParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify valid Backup object for Backup parameter .
        /// </summary>
        internal static string InvalidBackupObjectParameter {
            get {
                return ResourceManager.GetString("InvalidBackupObjectParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify valid string for BackupPolicyId parameter.
        /// </summary>
        internal static string InvalidBackupPolicyIdParameter {
            get {
                return ResourceManager.GetString("InvalidBackupPolicyIdParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify valid BackupPolicy object for BackupPolicy Parameter.
        /// </summary>
        internal static string InvalidBackupPolicyObjectParameter {
            get {
                return ResourceManager.GetString("InvalidBackupPolicyObjectParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Atleast one BackupSchedule should be present in BackupSchedulesToAdd parameter.
        /// </summary>
        internal static string InvalidBackupSchedulesToAddParameter {
            get {
                return ResourceManager.GetString("InvalidBackupSchedulesToAddParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provide valid datetime string for From parameter!.
        /// </summary>
        internal static string InvalidFromMessage {
            get {
                return ResourceManager.GetString("InvalidFromMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid input : {0}.
        /// </summary>
        internal static string InvalidInputMessage {
            get {
                return ResourceManager.GetString("InvalidInputMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provide valid datetime string for To parameter!.
        /// </summary>
        internal static string InvalidToMessage {
            get {
                return ResourceManager.GetString("InvalidToMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Atleast one VolumeId should be present in VolumeIdsToAdd parameter.
        /// </summary>
        internal static string InvalidVolumeIdsToAddParameter {
            get {
                return ResourceManager.GetString("InvalidVolumeIdsToAddParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Iscsi Connection{1} found!.
        /// </summary>
        internal static string IscsiConnectionGet_StatusMessage {
            get {
                return ResourceManager.GetString("IscsiConnectionGet_StatusMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No backuppolicy with name : {0} found in your device: {1} !.
        /// </summary>
        internal static string NoBackupPolicyWithGivenNameFound {
            get {
                return ResourceManager.GetString("NoBackupPolicyWithGivenNameFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No device found in your currently selected resource : {0}!.
        /// </summary>
        internal static string NoDeviceFoundInResourceMessage {
            get {
                return ResourceManager.GetString("NoDeviceFoundInResourceMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No device found in your currently selected resource : {0} with id : {1}!.
        /// </summary>
        internal static string NoDeviceFoundWithGivenIdInResourceMessage {
            get {
                return ResourceManager.GetString("NoDeviceFoundWithGivenIdInResourceMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No device found in your currently selected resource : {0} with ModelDescription : {1}!.
        /// </summary>
        internal static string NoDeviceFoundWithGivenModelInResourceMessage {
            get {
                return ResourceManager.GetString("NoDeviceFoundWithGivenModelInResourceMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No device found in your currently selected resource : {0} with name : {1}!.
        /// </summary>
        internal static string NoDeviceFoundWithGivenNameInResourceMessage {
            get {
                return ResourceManager.GetString("NoDeviceFoundWithGivenNameInResourceMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No device found in your currently selected resource : {0} with Type : {1}!.
        /// </summary>
        internal static string NoDeviceFoundWithGivenTypeInResourceMessage {
            get {
                return ResourceManager.GetString("NoDeviceFoundWithGivenTypeInResourceMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No resource found in your subscription!.
        /// </summary>
        internal static string NoResourceFoundInSubscriptionMessage {
            get {
                return ResourceManager.GetString("NoResourceFoundInSubscriptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No resource found in your subscription with name : {0}!.
        /// </summary>
        internal static string NoResourceFoundWithGivenNameInSubscriptionMessage {
            get {
                return ResourceManager.GetString("NoResourceFoundWithGivenNameInSubscriptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please provide the EncryptionKey..
        /// </summary>
        internal static string NotAllowedErrorDataContainerEncryption {
            get {
                return ResourceManager.GetString("NotAllowedErrorDataContainerEncryption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Volume container with name: {0} is not found..
        /// </summary>
        internal static string NotFoundDataContainerMessage {
            get {
                return ResourceManager.GetString("NotFoundDataContainerMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access control record with the specified name does not exist..
        /// </summary>
        internal static string NotFoundMessageACR {
            get {
                return ResourceManager.GetString("NotFoundMessageACR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified device does not exist..
        /// </summary>
        internal static string NotFoundMessageDevice {
            get {
                return ResourceManager.GetString("NotFoundMessageDevice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified resource does not exist..
        /// </summary>
        internal static string NotFoundMessageResource {
            get {
                return ResourceManager.GetString("NotFoundMessageResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Storage account with the specified name does not exist..
        /// </summary>
        internal static string NotFoundMessageStorageAccountCredential {
            get {
                return ResourceManager.GetString("NotFoundMessageStorageAccountCredential", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified volume does not exist..
        /// </summary>
        internal static string NotFoundMessageVirtualDisk {
            get {
                return ResourceManager.GetString("NotFoundMessageVirtualDisk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Volume with name: {0} is not found..
        /// </summary>
        internal static string NotFoundVolumeMessage {
            get {
                return ResourceManager.GetString("NotFoundVolumeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registration key parameter is not passed. Validating whether a registration key is already persisted for this resource!.
        /// </summary>
        internal static string NotProvidedWarningRegistrationKey {
            get {
                return ResourceManager.GetString("NotProvidedWarningRegistrationKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registration key is provided. Persisting for later use!.
        /// </summary>
        internal static string ProvidedRegistrationKey {
            get {
                return ResourceManager.GetString("ProvidedRegistrationKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registrtion key not passed - validating that the secrets are already initialized.
        /// </summary>
        internal static string RegistrationKeyNotPassedMessage {
            get {
                return ResourceManager.GetString("RegistrationKeyNotPassedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registration key passed - initializing secrets.
        /// </summary>
        internal static string RegistrationKeyPassedMessage {
            get {
                return ResourceManager.GetString("RegistrationKeyPassedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing backup with backupId {0}....
        /// </summary>
        internal static string RemoveASSDBackupMessage {
            get {
                return ResourceManager.GetString("RemoveASSDBackupMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing backuppolicy with backuppolicyId {0}....
        /// </summary>
        internal static string RemoveASSDBackupPolicyMessage {
            get {
                return ResourceManager.GetString("RemoveASSDBackupPolicyMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the backuppolicy with backuppolicyId{0}?.
        /// </summary>
        internal static string RemoveASSDBackupPolicyWarningMessage {
            get {
                return ResourceManager.GetString("RemoveASSDBackupPolicyWarningMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the backup with backupId{0}?.
        /// </summary>
        internal static string RemoveASSDBackupWarningMessage {
            get {
                return ResourceManager.GetString("RemoveASSDBackupWarningMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing access control record....
        /// </summary>
        internal static string RemoveConfirmationACR {
            get {
                return ResourceManager.GetString("RemoveConfirmationACR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing volume container....
        /// </summary>
        internal static string RemoveConfirmationDataContainer {
            get {
                return ResourceManager.GetString("RemoveConfirmationDataContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing storage account....
        /// </summary>
        internal static string RemoveConfirmationSAC {
            get {
                return ResourceManager.GetString("RemoveConfirmationSAC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing volume....
        /// </summary>
        internal static string RemoveConfirmationVolume {
            get {
                return ResourceManager.GetString("RemoveConfirmationVolume", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the access control record?.
        /// </summary>
        internal static string RemoveWarningACR {
            get {
                return ResourceManager.GetString("RemoveWarningACR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the volume container?.
        /// </summary>
        internal static string RemoveWarningDataContainer {
            get {
                return ResourceManager.GetString("RemoveWarningDataContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the storage account?.
        /// </summary>
        internal static string RemoveWarningSAC {
            get {
                return ResourceManager.GetString("RemoveWarningSAC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the volume?.
        /// </summary>
        internal static string RemoveWarningVolume {
            get {
                return ResourceManager.GetString("RemoveWarningVolume", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have a resource selected. Resource Name: {0} Id: {1}.
        /// </summary>
        internal static string ResourceContextFound {
            get {
                return ResourceManager.GetString("ResourceContextFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initializing resource context.
        /// </summary>
        internal static string ResourceContextInitializeMessage {
            get {
                return ResourceManager.GetString("ResourceContextInitializeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} StorSimple resource{1} found!.
        /// </summary>
        internal static string ResourceGet_StatusMessage {
            get {
                return ResourceManager.GetString("ResourceGet_StatusMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} volume containers found!.
        /// </summary>
        internal static string ReturnedCountDataContainerMessage {
            get {
                return ResourceManager.GetString("ReturnedCountDataContainerMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} volumes found for your volume container!.
        /// </summary>
        internal static string ReturnedCountVolumeMessage {
            get {
                return ResourceManager.GetString("ReturnedCountVolumeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Secrets validation complete.
        /// </summary>
        internal static string SecretsValidationCompleteMessage {
            get {
                return ResourceManager.GetString("SecretsValidationCompleteMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter Skip cannot be &lt;0.
        /// </summary>
        internal static string SkipParameterInvalidMessage {
            get {
                return ResourceManager.GetString("SkipParameterInvalidMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restoring backup with backupId {0}....
        /// </summary>
        internal static string StartASSDBackupRestoreJobMessage {
            get {
                return ResourceManager.GetString("StartASSDBackupRestoreJobMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to restore the backup with backupId{0}?.
        /// </summary>
        internal static string StartASSDBackupRestoreJobWarningMessage {
            get {
                return ResourceManager.GetString("StartASSDBackupRestoreJobWarningMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provide valid dateTime for StartFrom parameter.
        /// </summary>
        internal static string StartFromDateForBackupNotValid {
            get {
                return ResourceManager.GetString("StartFromDateForBackupNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cleaning up objects, retry count: {0}.
        /// </summary>
        internal static string StorageAccountCleanupRetryMessage {
            get {
                return ResourceManager.GetString("StorageAccountCleanupRetryMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Found storage account with name : {0}.
        /// </summary>
        internal static string StorageAccountFoundMessage {
            get {
                return ResourceManager.GetString("StorageAccountFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find storage account with name: {0}.
        /// </summary>
        internal static string StorageAccountNotFoundMessage {
            get {
                return ResourceManager.GetString("StorageAccountNotFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Storage credential verification failed..
        /// </summary>
        internal static string StorageCredentialVerificationFailureMessage {
            get {
                return ResourceManager.GetString("StorageCredentialVerificationFailureMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Storage credential verification succeeded..
        /// </summary>
        internal static string StorageCredentialVerificationSuccessMessage {
            get {
                return ResourceManager.GetString("StorageCredentialVerificationSuccessMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your resource has seen selected successfully. To change to another resource please use Select-AzureStorSimpleResource commandlet!.
        /// </summary>
        internal static string SuccessfulResourceSelection {
            get {
                return ResourceManager.GetString("SuccessfulResourceSelection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The job created for your {0} operation has completed successfully..
        /// </summary>
        internal static string SuccessMessageCompleteJob {
            get {
                return ResourceManager.GetString("SuccessMessageCompleteJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Context set successfully for the given resource name..
        /// </summary>
        internal static string SuccessMessageSetResourceContext {
            get {
                return ResourceManager.GetString("SuccessMessageSetResourceContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} job is submitted successfully. Please use the command Get-AzureStorSimpleJob -InstanceId {1} for tracking the job status.
        /// </summary>
        internal static string SuccessMessageSubmitJob {
            get {
                return ResourceManager.GetString("SuccessMessageSubmitJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The registration key has been validated successfully! .
        /// </summary>
        internal static string ValidationSuccessfulRegistrationKey {
            get {
                return ResourceManager.GetString("ValidationSuccessfulRegistrationKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Web exception encountered with StatusCode: {0}.
        /// </summary>
        internal static string WebExceptionMessage {
            get {
                return ResourceManager.GetString("WebExceptionMessage", resourceCulture);
            }
        }
    }
}
