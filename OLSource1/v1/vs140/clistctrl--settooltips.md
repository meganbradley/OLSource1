---
title: "CListCtrl::SetToolTips"
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
  - "CListCtrl.SetToolTips"
  - "CListCtrl::SetToolTips"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetToolTips method"
ms.assetid: 24fae3b8-3407-46a2-9859-dc9a7841a537
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SetToolTips
Sets the tooltip control that the list view control will use to display tooltips.  
  
## Syntax  
  
```  
  
      CToolTipCtrl* SetToolTips(  
   CToolTipCtrl* pWndTip   
);  
```  
  
#### Parameters  
 `pWndTip`  
 A pointer to a `CToolTipCtrl` object that the list control will use.  
  
## Return Value  
 A pointer to a [CToolTipCtrl](../vs140/ctooltipctrl-class.md) object containing the tooltip previously used by the control, or `NULL` if no tooltips were used previously.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [LVM_SETTOOLTIPS](http://msdn.microsoft.com/library/windows/desktop/bb761216), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 To not use tooltips, indicate the `LVS_NOTOOLTIPS` style when you create the `CListCtrl` object.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetToolTips](../vs140/clistctrl--gettooltips.md)