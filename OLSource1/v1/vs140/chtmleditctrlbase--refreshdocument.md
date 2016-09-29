---
title: "CHtmlEditCtrlBase::RefreshDocument"
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
  - "CHtmlEditCtrlBase::RefreshDocument"
  - "CHtmlEditCtrlBase<T>.RefreshDocument"
  - "RefreshDocument"
  - "CHtmlEditCtrlBase.RefreshDocument"
  - "CHtmlEditCtrlBase<T>::RefreshDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RefreshDocument method"
ms.assetid: 193c4442-26f6-4933-ae5b-40397491aec3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::RefreshDocument
Refreshes the current document.  
  
## Syntax  
  
```  
  
HRESULT RefreshDocument( ) const;  
  
```  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_REFRESH Command ID](https://msdn.microsoft.com/en-us/library/aa770020.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)