---
title: "CHtmlEditCtrlBase::SetDefaultComposeSettings"
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
  - CHtmlEditCtrlBase.SetDefaultComposeSettings
  - CHtmlEditCtrlBase::SetDefaultComposeSettings
  - CHtmlEditCtrlBase<T>::SetDefaultComposeSettings
  - SetDefaultComposeSettings
  - CHtmlEditCtrlBase<T>.SetDefaultComposeSettings
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetDefaultComposeSettings method
ms.assetid: 2a92762e-2728-42fa-b150-5f89cc4b2dea
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHtmlEditCtrlBase::SetDefaultComposeSettings
Call this method to set the default compose settings.  
  
## Syntax  
  
```  
  
      HRESULT SetDefaultComposeSettings(  
   LPCSTR szFontName = NULL,  
   unsigned short nFontSize = 3,  
   COLORREF crFontColor = 0xFF000000,  
   COLORREF crFontBgColor = 0xFF000000,  
   bool bBold = false,  
   bool bItalic = false,  
   bool bUnderline = false   
) const;  
```  
  
#### Parameters  
 *szFontName*  
 The font name.  
  
 *nFontSize*  
 The font size.  
  
 *crFontColor*  
 The font color.  
  
 *crFontBgColor*  
 The font background color.  
  
 *bBold*  
 Pass true for bold text.  
  
 `bItalic`  
 Pass true for italic text.  
  
 `bUnderline`  
 Pass true for underlined text.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_COMPOSESETTINGS command ID](https://msdn.microsoft.com/en-us/library/aa769901.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)