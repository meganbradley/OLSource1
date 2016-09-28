---
title: "CToolTipCtrl::SetTipBkColor"
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
  - "CToolTipCtrl.SetTipBkColor"
  - "CToolTipCtrl::SetTipBkColor"
  - "SetTipBkColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTipBkColor method"
ms.assetid: 72474925-0444-4160-a97b-03c283e01034
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolTipCtrl::SetTipBkColor
Sets the background color in a tool tip window.  
  
## Syntax  
  
```  
  
      void SetTipBkColor(  
   COLORREF clr   
);  
```  
  
#### Parameters  
 `clr`  
 The new background color.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TTM_SETTIPBKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760411), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolTipCtrl Class](../vs140/ctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolTipCtrl::GetTipBkColor](../vs140/ctooltipctrl--gettipbkcolor.md)