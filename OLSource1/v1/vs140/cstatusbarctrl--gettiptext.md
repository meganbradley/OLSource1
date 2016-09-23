---
title: "CStatusBarCtrl::GetTipText"
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
  - GetTipText
  - CStatusBarCtrl::GetTipText
  - CStatusBarCtrl.GetTipText
dev_langs: 
  - C++
helpviewer_keywords: 
  - tool tips [C++], retrieving text
  - GetTipText method
  - CStatusBarCtrl class, attributes
ms.assetid: 36d456ff-66e3-4930-abb5-04011a3763de
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CStatusBarCtrl::GetTipText
Retrieves the tooltip text for a pane in a status bar.  
  
## Syntax  
  
```  
  
      CString GetTipText(  
   int nPane   
) const;  
```  
  
#### Parameters  
 `nPane`  
 The zero-based index of status bar pane to receive the tooltip text.  
  
## Return Value  
 A [CString](../vs140/cstringt-class.md) object containing the text to be used in the tooltip.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [SB_GETTIPTEXT](http://msdn.microsoft.com/library/windows/desktop/bb760751), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CStatusBarCtrl#7](../vs140/codesnippet/CPP/cstatusbarctrl--gettiptext_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CStatusBar Class](../vs140/cstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatusBarCtrl::SetTipText](../vs140/cstatusbarctrl--settiptext.md)