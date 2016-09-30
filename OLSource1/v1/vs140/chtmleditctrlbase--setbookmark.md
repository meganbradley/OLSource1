---
title: "CHtmlEditCtrlBase::SetBookMark"
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
  - "CHtmlEditCtrlBase<T>::SetBookMark"
  - "SetBookmark"
  - "CHtmlEditCtrlBase::SetBookMark"
  - "CHtmlEditCtrlBase<T>.SetBookMark"
  - "CHtmlEditCtrlBase.SetBookMark"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBookmark method"
ms.assetid: dcf24221-47f7-42c7-ba35-b006f5f6ec5a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::SetBookMark
Creates a bookmark anchor for the current selection or insertion point.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *szAnchorName*  
 The anchor name.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_BOOKMARK command ID](https://msdn.microsoft.com/en-us/library/aa769873.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::GetBookMark](../vs140/chtmleditctrlbase--getbookmark.md)   
 [CHtmlEditCtrlBase::UnBookmark](../vs140/chtmleditctrlbase--unbookmark.md)