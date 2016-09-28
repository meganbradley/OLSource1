---
title: "IDebugDocumentTextEvents2::onUpdateTextAttributes"
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
  - "IDebugDocumentTextEvents2::OnUpdateTextAttributes"
helpviewer_keywords: 
  - "IDebugDocumentTextEvents2::onUpdateTextAttributes"
ms.assetid: eb68d69a-1ad9-4ce4-84e1-40979ef16634
caps.latest.revision: 14
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDocumentTextEvents2::onUpdateTextAttributes
Notifies the debug package that text attributes have been updated in the document.  
  
## Syntax  
  
```cpp#  
HRESULT onUpdateTextAttributes(   
   TEXT_POSITION pos,  
   DWORD         dwNumToUpdate  
);  
```  
  
```c#  
int onUpdateTextAttributes(   
   enum_TEXT_POSITION pos,  
   uint               dwNumToUpdate  
);  
```  
  
#### Parameters  
 `pos`  
 [in] A [TEXT_POSITION](../vs140/text_position.md) structure that indicates where the text attributes were updated.  
  
 `dwNumToUpdate`  
 [in] Specifies the number of characters of text that were updated.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugDocumentTextEvents2](../vs140/idebugdocumenttextevents2.md)   
 [TEXT_POSITION](../vs140/text_position.md)