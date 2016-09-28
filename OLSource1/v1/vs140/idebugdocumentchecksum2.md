---
title: "IDebugDocumentChecksum2"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugDocumentChecksum2 interface"
ms.assetid: 6d22fa94-21aa-46cb-b5b5-32a6399ebb20
caps.latest.revision: 11
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDocumentChecksum2
Represents a checksum for a debug document and enables passing the checksum between components.  
  
## Syntax  
  
```  
IDebugDocumentChecksum2 : IUnknown  
```  
  
## Notes for Implementers  
 This interface can be implemented by any component that exposes the [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md) interface. However, it is principally implemented by debug engines so that the checksum embedded in a symbol file (*.pdb) can be passed back to the IDE and used when finding a source.  
  
## Methods  
 The following table shows the methods of `IDebugDocumentChecksum2`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugDocumentChecksum2::GetChecksumAndAlgorithmId](../vs140/idebugdocumentchecksum2--getchecksumandalgorithmid.md)|Retrieves the document checksum and algorithm identifier given the maximum number of bytes to use.|  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll