---
title: "CHtmlEditCtrlBase::SetShowAlignedSiteTags"
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
  - "SetShowAlignedSiteTags"
  - "CHtmlEditCtrlBase<T>::SetShowAlignedSiteTags"
  - "CHtmlEditCtrlBase::SetShowAlignedSiteTags"
  - "CHtmlEditCtrlBase.SetShowAlignedSiteTags"
  - "CHtmlEditCtrlBase<T>.SetShowAlignedSiteTags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetShowAlignedSiteTags method"
ms.assetid: fcb3c943-3785-40b7-bf92-1bc4635fd778
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::SetShowAlignedSiteTags
Displays a glyph for all elements that have a **styleFloat** property.  
  
## Syntax  
  
```  
  
      HRESULT SetShowAlignedSiteTags(  
   bool bNewValue   
) const;  
```  
  
#### Parameters  
 `bNewValue`  
 If true, displays a glyph for all elements that have a **styleFloat** property.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM SHOWALIGNEDSITETAGS command ID](https://msdn.microsoft.com/en-us/library/aa769947.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::GetShowAlignedSiteTags](../vs140/chtmleditctrlbase--getshowalignedsitetags.md)