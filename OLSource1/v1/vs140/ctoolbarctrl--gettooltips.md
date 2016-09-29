---
title: "CToolBarCtrl::GetToolTips"
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
  - "CToolBarCtrl::GetToolTips"
  - "CToolBarCtrl.GetToolTips"
  - "GetToolTips"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetToolTips method"
ms.assetid: f2cdf90e-dedf-4944-a7cf-6a7b03447916
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::GetToolTips
Retrieves the handle of the tool tip control, if any, associated with the toolbar control.  
  
## Syntax  
  
```  
  
CToolTipCtrl* GetToolTips( ) const;  
```  
  
## Return Value  
 A pointer to the [CToolTipCtrl](../vs140/ctooltipctrl-class.md) object associated with this toolbar or **NULL** if the toolbar has no associated tool tip control.  
  
## Remarks  
 Since the toolbar control normally creates and maintains its own tool tip control, most programs don't need to call this function.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::SetToolTips](../vs140/ctoolbarctrl--settooltips.md)   
 [Handling Tool Tip Notifications](../vs140/handling-tool-tip-notifications.md)   
 [CToolTipCtrl Class](../vs140/ctooltipctrl-class.md)