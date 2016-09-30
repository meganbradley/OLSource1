---
title: "CHtmlEditCtrlBase::UnBookmark"
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
  - "UnBookmark"
  - "CHtmlEditCtrlBase<T>::UnBookmark"
  - "CHtmlEditCtrlBase.UnBookmark"
  - "CHtmlEditCtrlBase::UnBookmark"
  - "CHtmlEditCtrlBase<T>.UnBookmark"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UnBookmark method"
ms.assetid: d8ac5e4f-30a2-428c-9c5e-f18041cb73c3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::UnBookmark
Removes any bookmark from the current selection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM UNBOOKMARK command ID](https://msdn.microsoft.com/en-us/library/aa770034.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::SetBookMark](../vs140/chtmleditctrlbase--setbookmark.md)   
 [CHtmlEditCtrlBase::GetBookMark](../vs140/chtmleditctrlbase--getbookmark.md)