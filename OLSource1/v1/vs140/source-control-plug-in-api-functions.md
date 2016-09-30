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
|[SccCloseProject](../vs140/scccloseproject-function.md)|Closes a project.|  
|[SccGetCommandOptions](../vs140/sccgetcommandoptions-function.md)|Prompts the user for advanced options for the given command.|  
|[SccGetVersion](../vs140/sccgetversion-function.md)|Returns the version of the source control plug-in.|  
|[SccInitialize](../vs140/sccinitialize-function.md)|Initializes the source control plug-in. It is called once for each instance of the plug-in.|  
|[SccOpenProject](../vs140/sccopenproject-function.md)|Opens a project.|  
|[SccSetOption](../vs140/sccsetoption-function.md)|A generic function used to set a wide variety of options. Each option starts with <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and has its own defined set of values.|  
|[SccUninitialize](../vs140/sccuninitialize-function.md)|Called once when a source control plug-in needs to be unplugged.|  
  
## Core Source Control Functions  
  
|Function|Description|  
|--------------|-----------------|  
|[SccAdd](../vs140/sccadd-function.md)|Adds an array of files specified by fully qualified path names to the source control system.|  
|[SccAddFromScc](../vs140/sccaddfromscc-function.md)|Allows the user to browse for files that are already in the source control system and then make those files part of the current project.|  
|[SccCheckin](../vs140/scccheckin-function.md)|Checks in an array of files.|  
|[SccCheckout](../vs140/scccheckout-function.md)|Checks out an array of files.|  
|[SccDiff](../vs140/sccdiff-function.md)|Shows the differences between the local user's file specified by a fully qualified path name and the version under source control.|  
|[SccGet](../vs140/sccget-function.md)|Retrieves a read-only copy of a set of files.|  
|[SccGetEvents](../vs140/sccgetevents-function.md)|Checks the status of files that the caller has asked about (via <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>).|  
|[SccGetProjPath](../vs140/sccgetprojpath-function.md)|Causes the source control plug-in to prompt the user for a project path that is meaningful to the plug-in.|  
|[SccHistory](../vs140/scchistory-function.md)|Shows the history for an array of fully qualified local file names.|  
|[SccPopulateList](../vs140/sccpopulatelist-function.md)|Examines the list of files for their current status. In addition, uses the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function to notify the caller when a file does not match the criteria for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.|  
|[SccProperties](../vs140/sccproperties-function.md)|Shows the properties of a fully qualified file.|  
|[SccQueryInfo](../vs140/sccqueryinfo-function.md)|Examines a list of fully qualified files for their current status.|  
|[SccRemove](../vs140/sccremove-function.md)|Removes the array of fully qualified files from the source control system.|  
|[SccRename](../vs140/sccrename-function.md)|Renames the given file to a new name in the source control system.|  
|[SccRunScc](../vs140/sccrunscc-function.md)|Accesses the full range of features of the source control system.|  
|[SccUncheckout](../vs140/sccuncheckout-function.md)|Undoes a checkout of an array of files.|  
  
## Functions that Support Additional Capability (Version 1.2 of the Source Control Plug-in API)  
 This group of functions defines the additional functionality included in version 1.2 of the Source Control Plug-in API. They provide access to more advanced source control features and capabilities.  
  
|Function|Description|  
|--------------|-----------------|  
|[SccBeginBatch](../vs140/sccbeginbatch-function.md)|Starts a batch operation.|  
|[SccCreateSubProject](../vs140/scccreatesubproject-function.md)|Creates a subproject with the given name under an existing parent project.|  
|[SccDirDiff](../vs140/sccdirdiff-function.md)|Shows the differences between the local user's directory specified by a fully qualified path name and the source control database location.|  
|[SccDirQueryInfo](../vs140/sccdirqueryinfo-function.md)|Examines a list of fully qualified directories for their current status.|  
|[SccEndBatch](../vs140/sccendbatch-function.md)|Ends a batch operation.|  
|[SccGetParentProjectPath](../vs140/sccgetparentprojectpath-function.md)|Returns parent path of the given project (the project must exist).|  
|[SccIsMultiCheckoutEnabled](../vs140/sccismulticheckoutenabled-function.md)|Checks whether multiple checkouts on a file are allowed.|  
|[SccWillCreateSccFile](../vs140/sccwillcreatesccfile-function.md)|Checks whether the plug-in will create MSSCCPRJ.SCC files.|  
  
## Functions that Support Advanced Capability (Version 1.3 of the Source Control Plug-in API)  
 This group of functions defines the additional functionality included in version 1.3 of the Source Control Plug-in API. They provide access to more advanced source control features and capabilities.  
  
|Function|Description|  
|--------------|-----------------|  
|[SccAddFilesFromSCC](../vs140/sccaddfilesfromscc-function.md)|Adds a list of files from source control to the current project.|  
|[SccBackgroundGet](../vs140/sccbackgroundget-function.md)|Retrieves a list of files from source control without a user interface.|  
|[SccEnumChangedFiles](../vs140/sccenumchangedfiles-function.md)|Retrieves a list of files in source control that are different from the local files.|  
|[SccGetExtendedCapabilities](../vs140/sccgetextendedcapabilities-function.md)|Retrieves flags that specify extended capabilities supported by the source control plug-in.|  
|[SccGetUserOption](../vs140/sccgetuseroption-function.md)|Retrieves user-specific options.|  
|[SccPopulateDirList](../vs140/sccpopulatedirlist-function.md)|Examines a list of directories and files in a project or projects that are under source control. Each directory and file name found is passed to a callback function.|  
|[SccQueryChanges](../vs140/sccquerychanges-function.md)|Examines name changes made to a list of files. Each file name is passed to a callback function with its change status.|  
  
## Requirements  
 Header: scc.h  
  
 (Supplied in the Environment SDK common includes folder, by default *[drive]*\Program Files\VSIP 8.0\EnvSDK\common\inc; also supplied in the VSIP folder with the MSSCCI sample, *[drive]*\Program Files\VSIP 8.0\MSSCCI).  
  
## See Also  
 [Source Control Plug-ins](../vs140/source-control-plug-ins.md)   
 [Creating a Source Control Plug-in](../vs140/creating-a-source-control-plug-in.md)