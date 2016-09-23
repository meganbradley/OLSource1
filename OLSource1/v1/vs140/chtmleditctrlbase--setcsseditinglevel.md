---
title: "CHtmlEditCtrlBase::SetCSSEditingLevel"
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
  - CHtmlEditCtrlBase<T>.SetCSSEditingLevel
  - SetCSSEditingLevel
  - CHtmlEditCtrlBase.SetCSSEditingLevel
  - CHtmlEditCtrlBase<T>::SetCSSEditingLevel
  - CHtmlEditCtrlBase::SetCSSEditingLevel
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetCSSEditingLevel method
ms.assetid: d4d94c17-6405-4668-b5b9-3ee0729259d9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHtmlEditCtrlBase::SetCSSEditingLevel
Selects which CSS level (CSS1 or CSS2) the editor will support, if any.  
  
## Syntax  
  
```  
  
      HRESULT SetCSSEditingLevel(  
   short nLevel   
) const;  
```  
  
#### Parameters  
 `nLevel`  
 The CSS level. Pass 0 if you do not want CSS support.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_CSSEDITING_LEVEL command ID](https://msdn.microsoft.com/en-us/library/aa769903.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)