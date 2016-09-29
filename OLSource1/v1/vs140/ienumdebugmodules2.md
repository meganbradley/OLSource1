---
title: "IEnumDebugModules2"
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
  - "IEnumDebugModules2"
helpviewer_keywords: 
  - "IEnumDebugModules2"
ms.assetid: 4fe28074-a960-41ad-b74d-b57f04c0c0ad
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugModules2
This interface enumerates a list of modules.  
  
## Syntax  
  
```  
IEnumDebugModules2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface to represent a list of modules loaded for a program.  
  
## Notes for Callers  
 Visual Studio calls [IDebugProgram2::EnumModules](../vs140/idebugprogram2--enummodules.md) to obtain this interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IEnumDebugModules2`.  
  
|Method|Description|  
|------------|-----------------|  
|[Next](../vs140/ienumdebugmodules2--next.md)|Retrieves a specified number of modules in an enumeration sequence.|  
|[Skip](../vs140/ienumdebugmodules2--skip.md)|Skips a specified number of modules in an enumeration sequence.|  
|[Reset](../vs140/ienumdebugmodules2--reset.md)|Resets an enumeration sequence to the beginning.|  
|[Clone](../vs140/ienumdebugmodules2--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
|[GetCount](../vs140/ienumdebugmodules2--getcount.md)|Gets the number of modules.|  
  
## Remarks  
 Visual Studio uses this interface primarily to update the **Modules** window.  
  
 For the purposes of debugging in Visual Studio, a program is a logical sequence of code instructions that can cross module boundaries, hence the need for a list of modules for a single [IDebugProgram2](../vs140/idebugprogram2.md) interface. The first module in the list typically contains the initial entry point for the associated program.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [IDebugProgram2](../vs140/idebugprogram2.md)   
 [IDebugProgram2::EnumModules](../vs140/idebugprogram2--enummodules.md)