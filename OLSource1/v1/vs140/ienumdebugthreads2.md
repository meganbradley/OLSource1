---
title: "IEnumDebugThreads2"
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
  - "IEnumDebugThreads2"
helpviewer_keywords: 
  - "IEnumDebugThreads2"
ms.assetid: 1854f078-3b49-42c2-b65b-33e3b506fd63
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugThreads2
This interfac enumerates the threads running in the current debug session.  
  
## Syntax  
  
```  
IEnumDebugThreads2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface to represent a list of threads in a program.  
  
## Notes for Callers  
 Call [IDebugProcess2::EnumThreads](../vs140/idebugprocess2--enumthreads.md) to obtain this interface representing a list of all threads in all programs running in a process. Call [IDebugProgram2::EnumThreads](../vs140/idebugprogram2--enumthreads.md) to obtain this interface representing a list of threads running in a program.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IEnumDebugThreads2`.  
  
|Method|Description|  
|------------|-----------------|  
|[Next](../vs140/ienumdebugthreads2--next.md)|Retrieves a specified number of threads in the enumeration sequence.|  
|[Skip](../vs140/ienumdebugthreads2--skip.md)|Skips a specified number of threads in an enumeration sequence.|  
|[Reset](../vs140/ienumdebugthreads2--reset.md)|Resets an enumeration sequence to the beginning.|  
|[Clone](../vs140/ienumdebugthreads2--clone.md)|Creates an enumerator that contains the same enumeration state as the current one.|  
|[GetCount](../vs140/ienumdebugthreads2--getcount.md)|Gets the number of threads in an enumerator.|  
  
## Remarks  
 Visual Studio typically obtains this interface to update the **Threads** window as well as to obtain the first thread of the list, in order to call [IDebugProcess3::Execute](../vs140/idebugprocess3--execute.md), [IDebugProcess3::Continue](../vs140/idebugprocess3--continue.md), and [IDebugProcess3::Step](../vs140/idebugprocess3--step.md).  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [EnumThreads](../vs140/idebugprocess2--enumthreads.md)   
 [EnumThreads](../vs140/idebugprogram2--enumthreads.md)   
 [IDebugProcess3::Step](../vs140/idebugprocess3--step.md)   
 [IDebugProcess3::Continue](../vs140/idebugprocess3--continue.md)   
 [IDebugProcess3::Execute](../vs140/idebugprocess3--execute.md)