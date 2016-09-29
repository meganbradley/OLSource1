---
title: "IDebugDocumentTextEvents2::onDestroy"
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
  - "IDebugDocumentTextEvents2::OnDestroy"
helpviewer_keywords: 
  - "IDebugDocumentTextEvents2::onDestroy"
ms.assetid: 60e4689c-c899-4c14-9d18-96393b741e1f
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDocumentTextEvents2::onDestroy
Indicates that the entire document has been destroyed.  
  
## Syntax  
  
```cpp#  
HRESULT onDestroy(   
   void   
);  
```  
  
```c#  
int onDestroy();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugDocumentTextEvents2](../vs140/idebugdocumenttextevents2.md)