---
title: "Command Code Enumerator"
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
  - "command code enumerator"
  - "source control plug-ins, command code enumeration"
ms.assetid: 5d2c360c-59e4-4da8-bcb4-dd07c7441e40
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Command Code Enumerator
This enumerator is used in the options for the [SccGetCommandOptions Function](../VS_csharp/sccgetcommandoptions-function.md) and the [SccPopulateList Function](../VS_csharp/sccpopulatelist-function.md)to indicate the command for which the options are specified.  
  
## Syntax  
  
```  
enum SCCCOMMAND {  
   SCC_COMMAND_GET,  
   SCC_COMMAND_CHECKOUT,  
   SCC_COMMAND_CHECKIN,  
   SCC_COMMAND_UNCHECKOUT,  
   SCC_COMMAND_ADD,  
   SCC_COMMAND_REMOVE,  
   SCC_COMMAND_DIFF,  
   SCC_COMMAND_HISTORY,  
   SCC_COMMAND_RENAME,  
   SCC_COMMAND_PROPERTIES,  
   SCC_COMMAND_OPTIONS  
};  
```  
  
## Members  
 SCC_COMMAND_GET  
 Corresponds to the [SccGet Function](../VS_csharp/sccget-function.md).  
  
 SCC_COMMAND_CHECKOUT  
 Corresponds to the [SccCheckout Function](../VS_csharp/scccheckout-function.md).  
  
 SCC_COMMAND_CHECKIN  
 Corresponds to the [SccCheckin Function](../VS_csharp/scccheckin-function.md).  
  
 SCC_COMMAND_UNCHECKOUT  
 Corresponds to the [SccUncheckout Function](../VS_csharp/sccuncheckout-function.md).  
  
 SCC_COMMAND_ADD  
 Corresponds to the [SccAdd Function](../VS_csharp/sccadd-function.md).  
  
 SCC_COMMAND_REMOVE  
 Corresponds to the [SccRemove Function](../VS_csharp/sccremove-function.md).  
  
 SCC_COMMAND_DIFF  
 Corresponds to the [SccDiff Function](../VS_csharp/sccdiff-function.md).  
  
 SCC_COMMAND_HISTORY  
 Corresponds to the [SccHistory Function](../VS_csharp/scchistory-function.md).  
  
 SCC_COMMAND_RENAME  
 Corresponds to the [SccRename Function](../VS_csharp/sccrename-function.md).  
  
 SCC_COMMAND_PROPERTIES  
 Corresponds to the [SccProperties Function](../VS_csharp/sccproperties-function.md).  
  
 SCC_COMMAND_OPTIONS  
 Corresponds to the [SccSetOption Function](../VS_csharp/sccsetoption-function.md).  
  
## See Also  
 [Source Control Plug-ins](../VS_csharp/source-control-plug-ins.md)   
 [SccGetCommandOptions Function](../VS_csharp/sccgetcommandoptions-function.md)   
 [SccPopulateList Function](../VS_csharp/sccpopulatelist-function.md)