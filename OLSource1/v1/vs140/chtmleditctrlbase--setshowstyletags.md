---
title: "CHtmlEditCtrlBase::SetShowStyleTags"
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
  - CHtmlEditCtrlBase::SetShowStyleTags
  - SetShowStyleTags
  - CHtmlEditCtrlBase<T>.SetShowStyleTags
  - CHtmlEditCtrlBase<T>::SetShowStyleTags
  - CHtmlEditCtrlBase.SetShowStyleTags
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetShowStyleTags method
ms.assetid: cd118767-242e-472d-9d0f-dc3f05f88052
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHtmlEditCtrlBase::SetShowStyleTags
Displays a glyph for all the style tags.  
  
## Syntax  
  
```  
  
      HRESULT SetShowStyleTags(  
   bool bNewValue   
) const;  
```  
  
#### Parameters  
 `bNewValue`  
 If true, displays a glyph for all the style tags.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM SHOWSTYLETAGS command ID](https://msdn.microsoft.com/en-us/library/aa769954.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::GetShowStyleTags](../vs140/chtmleditctrlbase--getshowstyletags.md)