---
title: "CHtmlEditCtrlBase::IE50Paste"
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
  - "CHtmlEditCtrlBase.IE50Paste"
  - "IE50Paste"
  - "CHtmlEditCtrlBase<T>.IE50Paste"
  - "CHtmlEditCtrlBase::IE50Paste"
  - "CHtmlEditCtrlBase<T>::IE50Paste"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IE50Paste method"
ms.assetid: 804327a0-b354-42fd-b774-03e80178be15
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::IE50Paste
Performs a paste operation that's compatible with Internet Explorer 5.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The string to paste.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_IE50_PASTE command ID](https://msdn.microsoft.com/en-us/library/aa769922.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::SetIE5PasteMode](../vs140/chtmleditctrlbase--setie5pastemode.md)