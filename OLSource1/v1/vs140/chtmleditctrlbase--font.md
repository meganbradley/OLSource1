---
title: "CHtmlEditCtrlBase::Font"
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
  - "Font"
  - "CHtmlEditCtrlBase<T>.Font"
  - "CHtmlEditCtrlBase.Font"
  - "CHtmlEditCtrlBase::Font"
  - "CHtmlEditCtrlBase<T>::Font"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "font method"
ms.assetid: af653dc0-5e7d-45ad-9aa9-267bed37e69d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::Font
Opens a font dialog box to enable the user to change the text color, font, and font size of the current selection.  
  
## Syntax  
  
```  
  
HRESULT Font( ) const;  
  
```  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_FONT command ID](https://msdn.microsoft.com/en-us/library/aa769913.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)