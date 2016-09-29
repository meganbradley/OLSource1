---
title: "IDebugProgramEngines2"
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
  - "IDebugProgramEngines2"
helpviewer_keywords: 
  - "IDebugProgramEngines2 interface"
ms.assetid: 53d648f0-6c11-4337-badd-c43f3872b62c
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgramEngines2
This interface is used by program nodes to specify all the possible debug engines (DE) that can debug this program.  
  
## Syntax  
  
```  
IDebugProgramEngines2 : IUnknown  
```  
  
## Notes for Implementers  
 A DE or a custom port supplier implements this interface on the same object that implements [IDebugProgramNode2](../vs140/idebugprogramnode2.md) to support establishing a specific DE to use for a particular program.  
  
## Notes for Callers  
 Call [QueryInterface](../vs140/queryinterface.md) on an `IDebugProgramNode2` interface to obtain this interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugProgramEngines2`.  
  
|Method|Description|  
|------------|-----------------|  
|[EnumPossibleEngines](../vs140/idebugprogramengines2--enumpossibleengines.md)|Indicates all the possible DEs that can debug this program.|  
|[SetEngine](../vs140/idebugprogramengines2--setengine.md)|Selects the DE to use for debugging this program.|  
  
## Remarks  
 Once a DE is chosen by the user, that choice is registered with the program node by calling [IDebugProgramEngines2::SetEngine](../vs140/idebugprogramengines2--setengine.md). The selected engine becomes the engine returned by [IDebugProgramNode2::GetEngineInfo](../vs140/idebugprogramnode2--getengineinfo.md).  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [IDebugProgramNode2](../vs140/idebugprogramnode2.md)   
 [GetEngineInfo](../vs140/idebugprogramnode2--getengineinfo.md)