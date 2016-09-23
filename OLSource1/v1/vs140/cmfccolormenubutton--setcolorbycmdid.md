---
title: "CMFCColorMenuButton::SetColorByCmdID"
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
  - CMFCColorMenuButton.SetColorByCmdID
  - SetColorByCmdID
  - CMFCColorMenuButton::SetColorByCmdID
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetColorByCmdID method
ms.assetid: 1faaaa54-ac7d-4ba3-8f1c-6059850a3e99
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCColorMenuButton::SetColorByCmdID
Sets the color of the specified color menu button.  
  
## Syntax  
  
```  
static void SetColorByCmdID(  
   UINT uiCmdID,  
   COLORREF color  
);  
```  
  
#### Parameters  
 [in] `uiCmdID`  
 The resource ID of a color menu button.  
  
 [in] `color`  
 An RGB color value.  
  
## Requirements  
 **Header:** afxcolormenubutton.h  
  
## See Also  
 [CMFCColorMenuButton Class](../vs140/cmfccolormenubutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)