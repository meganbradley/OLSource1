---
title: "CHtmlEditCtrlBase::Marquee"
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
  - CHtmlEditCtrlBase<T>.Marquee
  - CHtmlEditCtrlBase.Marquee
  - CHtmlEditCtrlBase<T>::Marquee
  - CHtmlEditCtrlBase::Marquee
  - Marquee
dev_langs: 
  - C++
helpviewer_keywords: 
  - Marquee method
ms.assetid: b4350d2d-1dac-4e9e-aab8-8b6b241dafce
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHtmlEditCtrlBase::Marquee
Overwrites an empty marquee on the current selection.  
  
## Syntax  
  
```  
  
      HRESULT Marquee(  
   LPCTSTR szId = NULL   
) const;  
```  
  
#### Parameters  
 `szId`  
 The ID for the marquee.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_MARQUEE command ID](https://msdn.microsoft.com/en-us/library/aa769981.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)