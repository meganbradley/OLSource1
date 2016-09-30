---
title: "CHtmlEditCtrlBase::SetShowBRTags"
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
  - "CHtmlEditCtrlBase<T>::SetShowBRTags"
  - "CHtmlEditCtrlBase::SetShowBRTags"
  - "SetShowBRTags"
  - "CHtmlEditCtrlBase.SetShowBRTags"
  - "CHtmlEditCtrlBase<T>.SetShowBRTags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetShowBRTags method"
ms.assetid: 0e36b7eb-f876-4450-acd0-2487ff4af527
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::SetShowBRTags
Displays a glyph for all the br tags.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If true, displays a glyph for all the br tags.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM SHOWWBRTAGS command ID](https://msdn.microsoft.com/en-us/library/aa769956.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::GetShowBRTags](../vs140/chtmleditctrlbase--getshowbrtags.md)