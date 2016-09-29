---
title: "CHtmlEditCtrlBase::SetFontFace"
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
  - "CHtmlEditCtrlBase.SetFontFace"
  - "CHtmlEditCtrlBase<T>.SetFontFace"
  - "CHtmlEditCtrlBase::SetFontFace"
  - "CHtmlEditCtrlBase<T>::SetFontFace"
  - "SetFontFace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetFontFace method"
ms.assetid: a0262696-6e86-4f49-846e-b9d0b7b73d03
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::SetFontFace
Sets the font for the current selection.  
  
## Syntax  
  
```  
  
      HRESULT SetFontFace(  
   LPCTSTR szFace   
) const;  
```  
  
#### Parameters  
 `szFace`  
 The font name.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM FONTNAME Command ID](https://msdn.microsoft.com/en-us/library/aa769880.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::GetFontFace](../vs140/chtmleditctrlbase--getfontface.md)   
 [CHtmlEditCtrlBase::SetFontSize](../vs140/chtmleditctrlbase--setfontsize.md)