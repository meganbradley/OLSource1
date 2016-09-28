---
title: "CHtmlEditCtrlBase::SetShowAreaTags"
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
  - "CHtmlEditCtrlBase.SetShowAreaTags"
  - "CHtmlEditCtrlBase<T>.SetShowAreaTags"
  - "CHtmlEditCtrlBase<T>::SetShowAreaTags"
  - "SetShowAreaTags"
  - "CHtmlEditCtrlBase::SetShowAreaTags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetShowAreaTags method"
ms.assetid: bdd7fac7-98d4-4576-b6f6-a4e3c35a2479
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::SetShowAreaTags
Displays a glyph for all the area tags.  
  
## Syntax  
  
```  
  
      HRESULT SetShowAreaTags(  
   bool bNewValue   
) const;  
```  
  
#### Parameters  
 `bNewValue`  
 If true, displays a glyph for all the area tags.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM SHOWAREATAGS command ID](https://msdn.microsoft.com/en-us/library/aa769949.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::GetShowAreaTags](../vs140/chtmleditctrlbase--getshowareatags.md)