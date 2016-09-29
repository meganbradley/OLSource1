---
title: "Source Control Plug-in API Functions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "source control plug-ins, functions"
ms.assetid: 4b0536dd-4f92-4ef2-9031-4548281f37aa
caps.latest.revision: 23
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Source Control Plug-in API Functions
The Source Control Plug-in API provides the following functions, which must be implemented by the source control plug-in in accordance with this API. The signatures of each function and the semantics associated with the bit flags and other parameters are described in detail in this reference.  
  
## Initialization and Housekeeping Functions  
  
|Function|Description|  
|--------------|-----------------|  
|[SccCloseProject](../VS_csharp/scccloseproject-function.md)|Closes a project.|  
|[SccGetCommandOptions](../VS_csharp/sccgetcommandoptions-function.md)|Prompts the user for advanced options for the given command.|  
|[SccGetVersion](../VS_csharp/sccgetversion-function.md)|Returns the version of the source control plug-in.|  
|[SccInitialize](../VS_csharp/sccinitialize-function.md)|Initializes the source control plug-in. It is called once for each instance of the plug-in.|  
|[SccOpenProject](../VS_csharp/sccopenproject-function.md)|Opens a project.|  
|[SccSetOption](../VS_csharp/sccsetoption-function.md)|A generic function used to set a wide variety of options. Each option starts with `SCC_OPT_xxx` and has its own defined set of values.|  
|[SccUninitialize](../VS_csharp/sccuninitialize-function.md)|Called once when a source control plug-in needs to be unplugged.|  
  
## Core Source Control Functions  
  
|Function|Description|  
|--------------|-----------------|  
|[SccAdd](../VS_csharp/sccadd-function.md)|Adds an array of files specified by fully qualified path names to the source control system.|  
|[SccAddFromScc](../VS_csharp/sccaddfromscc-function.md)|Allows the user to browse for files that are already in the source control system and then make those files part of the current project.|  
|[SccCheckin](../VS_csharp/scccheckin-function.md)|Checks in an array of files.|  
|[SccCheckout](../VS_csharp/scccheckout-function.md)|Checks out an array of files.|  
|[SccDiff](../VS_csharp/sccdiff-function.md)|Shows the differences between the local user's file specified by a fully qualified path name and the version under source control.|  
|[SccGet](../VS_csharp/sccget-function.md)|Retrieves a read-only copy of a set of files.|  
|[SccGetEvents](../VS_csharp/sccgetevents-function.md)|Checks the status of files that the caller has asked about (via `SccQueryInfo`).|  
|[SccGetProjPath](../VS_csharp/sccgetprojpath-function.md)|Causes the source control plug-in to prompt the user for a project path that is meaningful to the plug-in.|  
|[SccHistory](../VS_csharp/scchistory-function.md)|Shows the history for an array of fully qualified local file names.|  
|[SccPopulateList](../VS_csharp/sccpopulatelist-function.md)|Examines the list of files for their current status. In addition, uses the `pfnPopulate` function to notify the caller when a file does not match the criteria for the `nCommand`.|  
|[SccProperties](../VS_csharp/sccproperties-function.md)|Shows the properties of a fully qualified file.|  
|[SccQueryInfo](../VS_csharp/sccqueryinfo-function.md)|Examines a list of fully qualified files for their current status.|  
|[SccRemove](../VS_csharp/sccremove-function.md)|Removes the array of fully qualified files from the source control system.|  
|[SccRename](../VS_csharp/sccrename-function.md)|Renames the given file to a new name in the source control system.|  
|[SccRunScc](../VS_csharp/sccrunscc-function.md)|Accesses the full range of features of the source control system.|  
|[SccUncheckout](../VS_csharp/sccuncheckout-function.md)|Undoes a checkout of an array of files.|  
  
## Functions that Support Additional Capability (Version 1.2 of the Source Control Plug-in API)  
 This group of functions defines the additional functionality included in version 1.2 of the Source Control Plug-in API. They provide access to more advanced source control features and capabilities.  
  
|Function|Description|  
|--------------|-----------------|  
|[SccBeginBatch](../VS_csharp/sccbeginbatch-function.md)|Starts a batch operation.|  
|[SccCreateSubProject](../VS_csharp/scccreatesubproject-function.md)|Creates a subproject with the given name under an existing parent project.|  
|[SccDirDiff](../VS_csharp/sccdirdiff-function.md)|Shows the differences between the local user's directory specified by a fully qualified path name and the source control database location.|  
|[SccDirQueryInfo](../VS_csharp/sccdirqueryinfo-function.md)|Examines a list of fully qualified directories for their current status.|  
|[SccEndBatch](../VS_csharp/sccendbatch-function.md)|Ends a batch operation.|  
|[SccGetParentProjectPath](../VS_csharp/sccgetparentprojectpath-function.md)|Returns parent path of the given project (the project must exist).|  
|[SccIsMultiCheckoutEnabled](../VS_csharp/sccismulticheckoutenabled-function.md)|Checks whether multiple checkouts on a file are allowed.|  
|[SccWillCreateSccFile](../VS_csharp/sccwillcreatesccfile-function.md)|Checks whether the plug-in will create MSSCCPRJ.SCC files.|  
  
## Functions that Support Advanced Capability (Version 1.3 of the Source Control Plug-in API)  
 This group of functions defines the additional functionality included in version 1.3 of the Source Control Plug-in API. They provide access to more advanced source control features and capabilities.  
  
|Function|Description|  
|--------------|-----------------|  
|[SccAddFilesFromSCC](../VS_csharp/sccaddfilesfromscc-function.md)|Adds a list of files from source control to the current project.|  
|[SccBackgroundGet](../VS_csharp/sccbackgroundget-function.md)|Retrieves a list of files from source control without a user interface.|  
|[SccEnumChangedFiles](../VS_csharp/sccenumchangedfiles-function.md)|Retrieves a list of files in source control that are different from the local files.|  
|[SccGetExtendedCapabilities](../VS_csharp/sccgetextendedcapabilities-function.md)|Retrieves flags that specify extended capabilities supported by the source control plug-in.|  
|[SccGetUserOption](../VS_csharp/sccgetuseroption-function.md)|Retrieves user-specific options.|  
|[SccPopulateDirList](../VS_csharp/sccpopulatedirlist-function.md)|Examines a list of directories and files in a project or projects that are under source control. Each directory and file name found is passed to a callback function.|  
|[SccQueryChanges](../VS_csharp/sccquerychanges-function.md)|Examines name changes made to a list of files. Each file name is passed to a callback function with its change status.|  
  
## Requirements  
 Header: scc.h  
  
 (Supplied in the Environment SDK common includes folder, by default *[drive]*\Program Files\VSIP 8.0\EnvSDK\common\inc; also supplied in the VSIP folder with the MSSCCI sample, *[drive]*\Program Files\VSIP 8.0\MSSCCI).  
  
## See Also  
 [Source Control Plug-ins](../VS_csharp/source-control-plug-ins.md)   
 [Creating a Source Control Plug-in](../VS_csharp/creating-a-source-control-plug-in.md)