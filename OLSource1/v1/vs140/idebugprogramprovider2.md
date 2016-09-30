---
title: "IDebugProgramProvider2"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugProgramProvider2"
helpviewer_keywords: 
  - "IDebugProgramProvider2 interface"
ms.assetid: a9ec7b3e-a59c-4069-b2ee-6f45916eeb78
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgramProvider2
This registered interface allows the session debug manager (SDM) to obtain information about programs that have been "published" through the [IDebugProgramPublisher2](../vs140/idebugprogrampublisher2.md) interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Notes for Implementers  
 The debug engine (DE) implements this interface to provide information about programs being debugged. This interface is registered in the DE section of the registry using the metric <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, as described in [Debugging SDK Helpers](../vs140/sdk-helpers-for-debugging.md).  
  
## Notes for Callers  
 Call COM's <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function with the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> of the program provider that is obtained from the registry. See the Example.  
  
## Methods in Vtable order  
  
|Method|Description|  
|------------|-----------------|  
|[GetProviderProcessData](../vs140/idebugprogramprovider2--getproviderprocessdata.md)|Obtains information about programs running, filtered in a variety of ways.|  
|[GetProviderProgramNode](../vs140/idebugprogramprovider2--getproviderprogramnode.md)|Gets a program node, given a specific process ID.|  
|[WatchForProviderEvents](../vs140/idebugprogramprovider2--watchforproviderevents.md)|Establishes a callback to watch for provider events associated with specific kinds of processes.|  
|[IDebugProgramProvider2::SetLocale](../vs140/idebugprogramprovider2--setlocale.md)|Establishes a locale for any language-specific resources needed by the DE.|  
  
## Remarks  
 Normally, a process uses this interface to find out about the programs running in that process.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [IDebugProgramPublisher2](../vs140/idebugprogrampublisher2.md)   
 [Debugging SDK Helpers](../vs140/sdk-helpers-for-debugging.md)