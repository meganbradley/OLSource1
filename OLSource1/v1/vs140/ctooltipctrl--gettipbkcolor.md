---
title: "CToolTipCtrl::GetTipBkColor"
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
  - GetTipBkColor
  - CToolTipCtrl::GetTipBkColor
  - CToolTipCtrl.GetTipBkColor
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetTipBkColor method
ms.assetid: c1042826-9468-4094-867f-0249c82a9520
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CToolTipCtrl::GetTipBkColor
Retrieves the background color in a tool tip window.  
  
## Syntax  
  
```  
  
COLORREF GetTipBkColor( ) const;  
  
```  
  
## Return Value  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that represents the background color.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TTM_GETTIPBKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760394), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolTipCtrl Class](../vs140/ctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolTipCtrl::SetTipBkColor](../vs140/ctooltipctrl--settipbkcolor.md)