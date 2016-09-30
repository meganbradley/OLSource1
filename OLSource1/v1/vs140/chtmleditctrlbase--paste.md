---
title: "CHtmlEditCtrlBase::Paste"
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
  - "CHtmlEditCtrlBase<T>::Paste"
  - "CHtmlEditCtrlBase.Paste"
  - "CHtmlEditCtrlBase<T>.Paste"
  - "CHtmlEditCtrlBase::Paste"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Paste method"
ms.assetid: ffb7d5e2-6938-4d7c-bb16-bc58fa190ff9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::Paste
Overwrites the contents of the clipboard on the current selection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_PASTE command ID](https://msdn.microsoft.com/en-us/library/aa770017.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::Copy](../vs140/chtmleditctrlbase--copy.md)   
 [CHtmlEditCtrlBase::Cut](../vs140/chtmleditctrlbase--cut.md)   
 [CHtmlEditCtrlBase::IE50Paste](../vs140/chtmleditctrlbase--ie50paste.md)