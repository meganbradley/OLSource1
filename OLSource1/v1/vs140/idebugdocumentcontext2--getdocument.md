---
title: "IDebugDocumentContext2::GetDocument"
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
  - "IDebugDocumentContext2::GetDocument"
helpviewer_keywords: 
  - "IDebugDocumentContext2::GetDocument"
ms.assetid: c6d46c5d-ade8-4dc8-9862-8fc7876658c4
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDocumentContext2::GetDocument
Gets the document that contains this document context.  
  
## Syntax  
  
```cpp#  
HRESULT GetDocument(   
   IDebugDocument2** ppDocument  
);  
```  
  
```c#  
int GetDocument(   
   out IDebugDocument2 ppDocument  
);  
```  
  
#### Parameters  
 `ppDocument`  
 [out] Returns an [IDebugDocument2](../vs140/idebugdocument2.md) object that represents the document that contains this document context.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method is for those debug engines that supply documents directly to the IDE. Otherwise, this method should return `E_NOTIMPL`.  
  
## See Also  
 [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md)   
 [IDebugDocument2](../vs140/idebugdocument2.md)