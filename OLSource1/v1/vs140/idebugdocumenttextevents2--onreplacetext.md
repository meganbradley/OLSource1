---
title: "IDebugDocumentTextEvents2::onReplaceText"
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
  - IDebugDocumentTextEvents2::OnReplaceText
helpviewer_keywords: 
  - IDebugDocumentTextEvents2::onReplaceText
ms.assetid: cb39f025-66d8-4dc0-bef6-1bdc8e07db92
caps.latest.revision: 14
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugDocumentTextEvents2::onReplaceText
Notifies the debug package that text has been replaced in the document.  
  
## Syntax  
  
```cpp#  
HRESULT onReplaceText(   
   TEXT_POSITION pos,  
   DWORD         dwNumToReplace  
);  
```  
  
```c#  
int onReplaceText(   
   enum_TEXT_POSITION pos,  
   uint               dwNumToReplace  
);  
```  
  
#### Parameters  
 `pos`  
 [in] A [TEXT_POSITION](../vs140/text_position.md) indicates where the text was replaced.  
  
 `dwNumToReplace`  
 [in] Specifies the number of characters of text that were replaced.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugDocumentTextEvents2](../vs140/idebugdocumenttextevents2.md)   
 [TEXT_POSITION](../vs140/text_position.md)