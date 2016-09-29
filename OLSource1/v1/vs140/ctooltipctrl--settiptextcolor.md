---
title: "CToolTipCtrl::SetTipTextColor"
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
  - "SetTipTextColor"
  - "CToolTipCtrl::SetTipTextColor"
  - "CToolTipCtrl.SetTipTextColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tool tips [C++], text color"
  - "SetTipTextColor method"
ms.assetid: 179613d2-a158-4a39-a1ba-1488b7b74de3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolTipCtrl::SetTipTextColor
Sets the text color in a tool tip window.  
  
## Syntax  
  
```  
  
      void SetTipTextColor(  
   COLORREF clr   
);  
```  
  
#### Parameters  
 `clr`  
 The new text color.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TTM_SETTIPTEXTCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760413), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolTipCtrl Class](../vs140/ctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolTipCtrl::GetTipTextColor](../vs140/ctooltipctrl--gettiptextcolor.md)