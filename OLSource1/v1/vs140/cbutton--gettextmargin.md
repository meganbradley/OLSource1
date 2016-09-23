---
title: "CButton::GetTextMargin"
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
  - CButton::GetTextMargin
  - CButton.GetTextMargin
  - GetTextMargin
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetTextMargin method
ms.assetid: b3d27e6c-b9c0-47d2-96df-97d91499b9f6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CButton::GetTextMargin
Call this method to get the text margin of the `CButton` object.  
  
## Syntax  
  
```  
  
      BOOL GetTextMargin(  
   RECT* pmargin   
);  
```  
  
#### Parameters  
 `pmargin`  
 A pointer to the text margin of the `CButton` object.  
  
## Return Value  
 Returns the text margin.  
  
## Remarks  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function emulates the functionality of the **BCM_GETTEXTMARGIN** message, as described in the [Buttons](http://msdn.microsoft.com/library/windows/desktop/bb775943) section of the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [CButton::SetTextMargin](../vs140/cbutton--settextmargin.md)