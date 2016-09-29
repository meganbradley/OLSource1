---
title: "IDebugDisassemblyStream2"
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
  - "IDebugDisassemblyStream2"
helpviewer_keywords: 
  - "IDebugDisassemblyStream2 interface"
ms.assetid: b03cab0c-3f0b-4cc6-88dc-acb3b48c567a
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDisassemblyStream2
This interface represents a stream of instructions.  
  
## Syntax  
  
```  
IDebugDisassemblyStream2 : IUnknown  
```  
  
## Notes for Implementers  
 A debug engine implements this interface to support disassembly of a program's code.  
  
## Notes for Callers  
 A call to the [IDebugProgram2::GetDisassemblyStream](../vs140/idebugprogram2--getdisassemblystream.md) method returns this interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugDisassemblyStream2`.  
  
|Method|Description|  
|------------|-----------------|  
|[Read](../vs140/idebugdisassemblystream2--read.md)|Reads instructions starting from the current position in the disassembly stream.|  
|[Seek](../vs140/idebugdisassemblystream2--seek.md)|Moves the read pointer in the disassembly stream a given number of instructions relative to a specified position.|  
|[GetCodeLocationId](../vs140/idebugdisassemblystream2--getcodelocationid.md)|Returns a code location identifier for a particular code context.|  
|[GetCodeContext](../vs140/idebugdisassemblystream2--getcodecontext.md)|Returns a code context object corresponding to a specified code location identifier.|  
|[GetCurrentLocation](../vs140/idebugdisassemblystream2--getcurrentlocation.md)|Returns a code location identifier that represents the current code location.|  
|[GetDocument](../vs140/idebugdisassemblystream2--getdocument.md)|Gets the source document associated with this disassembly stream.|  
|[GetScope](../vs140/idebugdisassemblystream2--getscope.md)|Gets the scope of this disassembly stream.|  
|[GetSize](../vs140/idebugdisassemblystream2--getsize.md)|Gets the size of this disassembly stream.|  
  
## Remarks  
 The disassembly stream can be created to represent the entire address space or just a function or module within the space. Each instruction is represented by a [DisassemblyData](../vs140/disassemblydata.md) structure returned by a call to the [IDebugDisassemblyStream2::Read](../vs140/idebugdisassemblystream2--read.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [GetDisassemblyStream](../vs140/idebugprogram2--getdisassemblystream.md)   
 [DisassemblyData](../vs140/disassemblydata.md)