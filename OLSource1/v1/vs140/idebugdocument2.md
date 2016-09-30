---
title: "IDebugDocument2"
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
  - "IDebugDocument2"
helpviewer_keywords: 
  - "IDebugDocument2 interface"
ms.assetid: 1bc58426-dbf5-4471-9aad-9d66cd80eef0
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDocument2
This interface represents a source document.  
  
## Syntax  
  
```  
IDebugDocument2 : IUnknown  
```  
  
## Notes for Implementers  
 [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] typically implements this interface. A debug engine (DE) can also implement this interface when it needs to supply the source code and the source does not exist on disk.  In such cases, the DE would also implement [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md) and [IDebugActivateDocumentEvent2](../vs140/idebugactivatedocumentevent2.md) interfaces, as well as some additional methods on the [IDebugDisassemblyStream2](../vs140/idebugdisassemblystream2.md) and [IDebugDocumentPosition2](../vs140/idebugdocumentposition2.md) interfaces.  
  
## Notes for Callers  
 Methods on the `IDebugDocumentContext2`, `IDebugDisassemblyStream2`, `IDebugDocumentPosition2`, and `IDebugActivateDocumentEvent2` interfaces return this interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugDocument2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetName](../vs140/idebugdocument2--getname.md)|Gets the name of the document in one of several forms.|  
|[GetDocumentClassID](../vs140/idebugdocument2--getdocumentclassid.md)|Gets the class identifier of the document.|  
  
## Remarks  
 This interface is implemented only when the DE supplies the source code. For example, when you are debugging script on an HTML page, the DE supplies the source code because the source is downloaded or generated dynamically and does not exist as a disk file. When debugging traditional languages, such as C++, this interface does not need to be implemented.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IsPositionInDocument](../vs140/idebugdocumentposition2--ispositionindocument.md)   
 [GetDocument](../vs140/idebugactivatedocumentevent2--getdocument.md)   
 [GetDocument](../vs140/idebugdocumentcontext2--getdocument.md)   
 [GetDocument](../vs140/idebugdocumentposition2--getdocument.md)   
 [IDebugDisassemblyStream2::GetDocument](../vs140/idebugdisassemblystream2--getdocument.md)