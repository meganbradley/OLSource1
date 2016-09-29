---
title: "CHtmlEditCtrlBase::GetDocumentHTML"
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
  - "CHtmlEditCtrlBase<T>.GetDocumentHTML"
  - "CHtmlEditCtrlBase::GetDocumentHTML"
  - "GetDocumentHTML"
  - "CHtmlEditCtrlBase<T>::GetDocumentHTML"
  - "CHtmlEditCtrlBase.GetDocumentHTML"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDocumentHTML method"
ms.assetid: 72f9782b-8b96-448a-8d58-7fb169ade06e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::GetDocumentHTML
Retrieves the HTML of the current document.  
  
## Syntax  
  
```  
  
      HRESULT GetDocumentHTML(  
   CString& szHTML   
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
 [CHtmlEditCtrlBase::SetDocumentHTML](../vs140/chtmleditctrlbase--setdocumenthtml.md)