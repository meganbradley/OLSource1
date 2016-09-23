---
title: "IDebugActivateDocumentEvent2::GetDocument"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - IDebugActivateDocumentEvent2::GetDocument
helpviewer_keywords: 
  - GetDocument method
  - IDebugActivateDocumentEvent2::GetDocument method
ms.assetid: b3c32f1b-f3de-409d-920d-ba7b3fa84fcd
caps.latest.revision: 14
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugActivateDocumentEvent2::GetDocument
Gets the document to activate.  
  
## Syntax  
  
```cpp#  
HRESULT GetDocument (   
   IDebugDocument2** ppDoc  
);  
```  
  
```c#  
int GetDocument (   
   out IDebugDocument2 ppDoc  
);  
```  
  
#### Parameters  
 `ppDoc`  
 [out] Returns an [IDebugDocument2](../vs140/idebugdocument2.md) object that represents the document to be activated.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugActivateDocumentEvent2](../vs140/idebugactivatedocumentevent2.md)   
 [IDebugDocument2](../vs140/idebugdocument2.md)