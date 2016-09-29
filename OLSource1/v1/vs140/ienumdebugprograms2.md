---
title: "IEnumDebugPrograms2"
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
  - "IEnumDebugPrograms2"
helpviewer_keywords: 
  - "IEnumDebugPrograms2"
ms.assetid: 7fbb8fb7-db64-4546-a364-dc668430c8af
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugPrograms2
This interface enumerates the programs running in the current debug session.  
  
## Syntax  
  
```  
IEnumDebugPrograms2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface to provide a list of programs being debugged by the DE.  
  
## Notes for Callers  
 Visual Studio calls [IDebugProcess2::EnumPrograms](../vs140/idebugprocess2--enumprograms.md) to obtain this interface. [IDebugEngine2::EnumPrograms](../vs140/idebugengine2--enumprograms.md) is not used by Visual Studio.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IEnumDebugPrograms2`.  
  
|Method|Description|  
|------------|-----------------|  
|[Next](../vs140/ienumdebugprograms2--next.md)|Retrieves a specified number of programs in an enumeration sequence.|  
|[Skip](../vs140/ienumdebugprograms2--skip.md)|Skips a specified number of programs in an enumeration sequence.|  
|[Reset](../vs140/ienumdebugprograms2--reset.md)|Resets an enumeration sequence to the beginning.|  
|[Clone](../vs140/ienumdebugprograms2--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
|[GetCount](../vs140/ienumdebugprograms2--getcount.md)|Gets the number of programs in an enumerator.|  
  
## Remarks  
 Visual Studio uses this interface to:  
  
-   Populate the **Modules** window (by calling [IDebugProcess2::EnumPrograms](../vs140/idebugprocess2--enumprograms.md) and then calling [IDebugProgram2::EnumModules](../vs140/idebugprogram2--enummodules.md) on each program).  
  
-   Populate the **Attach to Process** list (by calling `IDebugProcess2::EnumPrograms` and then calling [QueryInterface](../vs140/queryinterface.md) on each [IDebugProgram2](../vs140/idebugprogram2.md) interface to obtain an [IDebugEngineProgram2](../vs140/idebugengineprogram2.md) interface).  
  
-   Generate a list of DEs that can debug each program in the process (using [IDebugProgram2::GetEngineInfo](../vs140/idebugprogram2--getengineinfo.md)).  
  
-   Apply Edit and Continue (ENC) updates to each program (by calling IDebugProcess2::EnumPrograms and then calling [IDebugProgram2::GetENCUpdate](../vs140/idebugprogram2--getencupdate.md)).  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [EnumPrograms](../vs140/idebugengine2--enumprograms.md)   
 [EnumPrograms](../vs140/idebugprocess2--enumprograms.md)