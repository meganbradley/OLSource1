---
title: "IEnumDebugProcesses2"
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
  - "IEnumDebugProcesses2"
helpviewer_keywords: 
  - "IEnumDebugProcesses2"
ms.assetid: 06a1368f-10f0-44eb-af61-e388c2327111
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugProcesses2
This interface enumerates the processes running on a debug port.  
  
## Syntax  
  
```  
IEnumDebugProcesses : IUnknown  
```  
  
## Notes for Implementers  
 A custom port supplier implements this interface to provide a list of processes running on a port.  
  
## Notes for Callers  
 Visual Studio calls [IDebugPort2::EnumProcesses](../vs140/idebugport2--enumprocesses.md) to obtain this interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IEnumDebugProcesses2`.  
  
|Method|Description|  
|------------|-----------------|  
|[Next](../vs140/ienumdebugprocesses2--next.md)|Retrieves a specified number of processes in an enumeration sequence.|  
|[Skip](../vs140/ienumdebugprocesses2--skip.md)|Skips a specified number of processes in an enumeration sequence.|  
|[Reset](../vs140/ienumdebugprocesses2--reset.md)|Resets an enumeration sequence to the beginning.|  
|[Clone](../vs140/ienumdebugprocesses2--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
|[GetCount](../vs140/ienumdebugprocesses2--getcount.md)|Gets the number of processes in an enumerator.|  
  
## Remarks  
 Visual Studio uses this interface to populate the **Processes** window.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [EnumProcesses](../vs140/idebugport2--enumprocesses.md)