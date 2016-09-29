---
title: "IDebugDocumentPosition2"
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
  - "IDebugDocumentPosition2"
helpviewer_keywords: 
  - "IDebugDocumentPosition2 interface"
ms.assetid: 0e838ced-12bb-4efc-b811-2b7c034b77b0
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDocumentPosition2
This interface represents an abstract position in a source file.  
  
## Syntax  
  
```  
IDebugDocumentPosition2 : IUnknown  
```  
  
## Notes for Implementers  
 Visual Studio typically implements this interface. A debug engine (DE) would also implement this interface if it must supply its own source code (as when the DE implements the [IDebugDocument2](../VS_csharp/idebugdocument2.md) interface).  
  
## Notes for Callers  
 This interface is passed in as an argument to [IDebugProgram2::EnumCodeContexts](../VS_csharp/idebugprogram2--enumcodecontexts.md). It is also supplied as part of a [BP_LOCATION](../VS_csharp/bp_location.md) union (specifically, a [BP_LOCATION_CODE_FILE_LINE](../VS_csharp/bp_location_code_file_line.md) structure) that is in turn part of the [BP_REQUEST_INFO](../VS_csharp/bp_request_info.md) structure, that is used in creating a pending breakpoint.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugDocumentPosition2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetFileName](../VS_csharp/idebugdocumentposition2--getfilename.md)|Gets the file name of the source file that contains this document position.|  
|[GetDocument](../VS_csharp/idebugdocumentposition2--getdocument.md)|Gets the containing document.|  
|[IsPositionInDocument](../VS_csharp/idebugdocumentposition2--ispositionindocument.md)|Determines if this position is contained in the given document.|  
|[GetRange](../VS_csharp/idebugdocumentposition2--getrange.md)|Gets the range for this document position.|  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [EnumCodeContexts](../VS_csharp/idebugprogram2--enumcodecontexts.md)   
 [IDebugProgram2](../VS_csharp/idebugprogram2.md)   
 [BP_LOCATION_CODE_FILE_LINE](../VS_csharp/bp_location_code_file_line.md)