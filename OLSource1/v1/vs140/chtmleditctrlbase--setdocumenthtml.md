---
title: "CHtmlEditCtrlBase::SetDocumentHTML"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CHtmlEditCtrlBase::SetDocumentHTML"
  - "CHtmlEditCtrlBase<T>::SetDocumentHTML"
  - "CHtmlEditCtrlBase.SetDocumentHTML"
  - "SetDocumentHTML"
  - "CHtmlEditCtrlBase<T>.SetDocumentHTML"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDocumentHTML method"
ms.assetid: 7e5fc72d-6820-4cc1-9457-5418cdc32ddd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::SetDocumentHTML
Sets the HTML of the current document.  
  
## Syntax  
  
```  
  
      HRESULT SetDocumentHTML(  
   LPCTSTR szHTML   
) const;  
```  
  
#### Parameters  
 `szHTML`  
 The HTML.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::GetDocumentHTML](../vs140/chtmleditctrlbase--getdocumenthtml.md)