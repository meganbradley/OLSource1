---
title: "Enumerators"
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
  - "source control plug-ins, enumerators"
ms.assetid: a60030c5-e1d1-47e1-84bb-cbfe838ab479
caps.latest.revision: 23
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Enumerators
This section lists the enumerator data types in the Source Control Plug-in API that the source control plug-in must know about.  
  
## In This Section  
 [Command Code](../VS_csharp/command-code-enumerator.md)  
 Enumerates the options for the [SccGetCommandOptions Function](../VS_csharp/sccgetcommandoptions-function.md) and [SccPopulateList Function](../VS_csharp/sccpopulatelist-function.md) functions.  
  
 [Message](../VS_csharp/message-enumerator.md)  
 Enumerates flags used for the print callback, [LPTEXTOUTPROC](../VS_csharp/lptextoutproc.md).  
  
 [File Status Code](../VS_csharp/file-status-code-enumerator.md)  
 Contains named constant values that specify the state of a file under source control.  
  
 [Directory Status Code](../VS_csharp/directory-status-code-enumerator.md)  
 Contains named constant values that specify the state of a directory under source control.  
  
## Related Sections  
 [Creating a Source Control Plug-in](../VS_csharp/creating-a-source-control-plug-in.md)  
 Defines the Source Control Plug-in SDK and describes the included resources.  
  
 [SccGetCommandOptions Function](../VS_csharp/sccgetcommandoptions-function.md)  
 Prompts the user for advanced options for the given command.  
  
 [SccPopulateList Function](../VS_csharp/sccpopulatelist-function.md)  
 Examines the list of files for their current status. In addition, uses the `pfnPopulate` function to notify the caller when a file does not match the criteria for the `nCommand`.  
  
 [LPTEXTOUTPROC](../VS_csharp/lptextoutproc.md)  
 Describes the callback function that is used by [SccOpenProject Function](../VS_csharp/sccopenproject-function.md) to display messages from the source control plug-in through the IDE.  
  
 [Source Control Plug-ins](../VS_csharp/source-control-plug-ins.md)  
 Provides a complete listing of all the elements in the Source Control Plug-in API.