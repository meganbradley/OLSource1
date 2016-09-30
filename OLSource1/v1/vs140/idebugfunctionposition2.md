---
title: "IDebugFunctionPosition2"
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
  - "IDebugFunctionPosition2"
helpviewer_keywords: 
  - "IDebugFunctionPosition2 interface"
ms.assetid: a835f65b-91b0-48ad-8485-04534c814b1b
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugFunctionPosition2
This interface represents an abstract position of a function in a source document.  
  
## Syntax  
  
```  
IDebugFunctionPosition2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface to represent the position of a function within a source document.  
  
## Notes for Callers  
 This interface is supplied as part of a [BP_LOCATION](../vs140/bp_location.md) union (specifically, a [BP_LOCATION_CODE_FUNC_OFFSET](../vs140/bp_location_code_func_offset.md) structure) that is in turn part of the [BP_REQUEST_INFO](../vs140/bp_request_info.md) structure, used in creating a pending breakpoint.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugFunctionPosition2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetFunctionName](../vs140/idebugfunctionposition2--getfunctionname.md)|Gets the name of the function that this position is relative to.|  
|[GetOffset](../vs140/idebugfunctionposition2--getoffset.md)|Gets the offset from the beginning of the function.|  
  
## Remarks  
 The position represented by this interface is text-based, specifically, a [TEXT_POSITION](../vs140/text_position.md) structure.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [BP_LOCATION_CODE_FUNC_OFFSET](../vs140/bp_location_code_func_offset.md)   
 [BP_LOCATION](../vs140/bp_location.md)   
 [TEXT_POSITION](../vs140/text_position.md)