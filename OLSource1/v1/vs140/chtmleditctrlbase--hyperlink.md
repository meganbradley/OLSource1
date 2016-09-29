---
title: "CHtmlEditCtrlBase::HyperLink"
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
  - "CHtmlEditCtrlBase<T>::HyperLink"
  - "CHtmlEditCtrlBase::HyperLink"
  - "HyperLink"
  - "CHtmlEditCtrlBase.HyperLink"
  - "CHtmlEditCtrlBase<T>.HyperLink"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HyperLink method"
ms.assetid: f47b3b02-a218-44cb-ba42-65fc3c6e9234
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::HyperLink
Inserts a hyperlink on the current selection.  
  
## Syntax  
  
```  
  
      HRESULT HyperLink(  
   LPCTSTR szUrl = NULL   
) const;  
```  
  
#### Parameters  
 `szUrl`  
 The hyperlink URL.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_HYPERLINK command ID](https://msdn.microsoft.com/en-us/library/aa769874.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::Unlink](../vs140/chtmleditctrlbase--unlink.md)