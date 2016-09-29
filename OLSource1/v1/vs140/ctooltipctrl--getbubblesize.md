---
title: "CToolTipCtrl::GetBubbleSize"
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
  - "GetBubbleSize"
  - "CToolTipCtrl.GetBubbleSize"
  - "CToolTipCtrl::GetBubbleSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetBubbleSize method"
ms.assetid: aa0da707-65d9-4b04-a90d-38be0d41768f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolTipCtrl::GetBubbleSize
Retrieves the size of the tool tip.  
  
## Syntax  
  
```  
  
      CSize GetBubbleSize(  
   LPTOOLINFO lpToolInfo   
) const;  
```  
  
#### Parameters  
 `lpToolInfo`  
 A pointer to the tool tip's [TOOLINFO](http://msdn.microsoft.com/library/windows/desktop/bb760256) structure.  
  
## Return Value  
 The size of the tool tip.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TTM_GETBUBBLESIZE](http://msdn.microsoft.com/library/windows/desktop/bb760387), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolTipCtrl Class](../vs140/ctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolTipCtrl::AdjustRect](../vs140/ctooltipctrl--adjustrect.md)