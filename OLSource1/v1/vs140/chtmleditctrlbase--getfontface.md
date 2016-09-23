---
title: "CHtmlEditCtrlBase::GetFontFace"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CHtmlEditCtrlBase.GetFontFace
  - CHtmlEditCtrlBase::GetFontFace
  - CHtmlEditCtrlBase<T>::GetFontFace
  - CHtmlEditCtrlBase<T>.GetFontFace
  - GetFontFace
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetFontFace method
ms.assetid: 47e14efa-fb55-4171-a7aa-40ac2c94aeeb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHtmlEditCtrlBase::GetFontFace
Retrieves the font name for the current selection.  
  
## Syntax  
  
```  
  
      HRESULT GetFontFace(  
   CString& strFace   
) const;  
```  
  
#### Parameters  
 `strFace`  
 The font name.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 If the current selection uses more than one font, `strFace` will be an empty string.  
  
 This method sends the [IDM_FONTNAME command ID](https://msdn.microsoft.com/en-us/library/aa769880.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::SetFontFace](../vs140/chtmleditctrlbase--setfontface.md)   
 [CHtmlEditCtrlBase::GetFontSize](../vs140/chtmleditctrlbase--getfontsize.md)