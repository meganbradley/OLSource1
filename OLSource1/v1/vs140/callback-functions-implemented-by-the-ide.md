---
title: "Callback Functions Implemented by the IDE"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - source control plug-ins, callback functions
  - callback functions, source control plug-ins
ms.assetid: 4a8833f0-6ac0-4ea7-9400-8275aa991468
caps.latest.revision: 28
translation.priority.mt: 
  - de-de
  - ja-jp
---
# Callback Functions Implemented by the IDE
To make integration with the integrated development environment (IDE) as seamless as possible and to provide a unified end-user experience, the source control plug-in can use callback functions that are implemented by the IDE. The plug-in can call these functions at appropriate times during a source control operation to pass information to the IDE; the IDE can then display this information as embedded elements in its native UI. The user has a less fragmented experience in this scenario than if the plug-in employed its own UI.  
  
 The required header file is scc.h. The default location is \Program Files\VSIP 8.0\EnvSDK\common\inc\\. It is also in the VSIP folder that has the source control plug-in sample at \Program Files\VSIP 8.0\MSSCCI\\.  
  
## In This Section  
 [LPTEXTOUTPROC](../vs140/lptextoutproc.md)  
 Describes the callback function that is used by [SccOpenProject Function](../vs140/sccopenproject-function.md) to display messages from the source control plug-in through the IDE.  
  
 [POPLISTFUNC](../vs140/poplistfunc.md)  
 Describes the callback function that is used by [SccPopulateList Function](../vs140/sccpopulatelist-function.md) when the IDE does not have complete access to information that is available only to the source control plug-in, such as a complete list of files under version control.  
  
 [QUERYCHANGESFUNC](../vs140/querychangesfunc.md)  
 Describes the callback function that is used by the [SccQueryChanges Function](../vs140/sccquerychanges-function.md) operation.  
  
 [POPDIRLISTFUNC](../vs140/popdirlistfunc.md)  
 Describes the callback function that is used by the [SccPopulateDirList Function](../vs140/sccpopulatedirlist-function.md) operation.  
  
 [OPTNAMECHANGEPFN](../vs140/optnamechangepfn.md)  
 Describes the callback function set by a call to the [SccSetOption Function](../vs140/sccsetoption-function.md) that enables the source control plug-in to communicate name changes back to the IDE.  
  
## Related Sections  
 [SccOpenProject Function](../vs140/sccopenproject-function.md)  
 Opens a project.  
  
 [SccPopulateList Function](../vs140/sccpopulatelist-function.md)  
 Examines the list of files for their current status. In addition, uses the `pfnPopulate` function to notify the caller when a file does not match the criteria for the `nCommand`.  
  
 [SccPopulateDirList Function](../vs140/sccpopulatedirlist-function.md)  
 Examines a list of directories and files in a project or projects that are under source control. Each directory and file name found is passed to a callback function.  
  
 [SccQueryChanges Function](../vs140/sccquerychanges-function.md)  
 Examines name changes that were made to a list of files. Each file name is passed to a callback function together with its change status.  
  
 [SccSetOption Function](../vs140/sccsetoption-function.md)  
 Sets a wide variety of options. Each option starts with `SCC_OPT_xxx` and has its own defined set of values.  
  
 [Source Control Plug-ins](../vs140/source-control-plug-ins.md)  
 Describes the contents of the reference section of the Source Control Plug-in SDK.