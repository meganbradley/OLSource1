---
title: "CHtmlEditCtrlBase::Unlink"
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
  - "CHtmlEditCtrlBase::Unlink"
  - "CHtmlEditCtrlBase<T>.Unlink"
  - "CHtmlEditCtrlBase.Unlink"
  - "CHtmlEditCtrlBase<T>::Unlink"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Unlink method"
ms.assetid: 4d651cb8-68fa-4bca-ad13-22729be514c1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::Unlink
Removes any hyperlink from the current selection.  
  
## Syntax  
  
```  
  
HRESULT Unlink( ) const;  
  
```  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM UNLINK command ID](https://msdn.microsoft.com/en-us/library/aa770037.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::HyperLink](../vs140/chtmleditctrlbase--hyperlink.md)