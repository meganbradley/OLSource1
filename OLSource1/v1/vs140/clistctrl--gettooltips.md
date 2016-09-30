---
title: "CListCtrl::GetToolTips"
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
  - "CListCtrl::GetToolTips"
  - "GetToolTips"
  - "CListCtrl.GetToolTips"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetToolTips method"
ms.assetid: 1627cdb2-a5c9-46bd-99c4-2c7a7637bf70
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetToolTips
Retrieves the tooltip control that the list view control uses to display tooltips.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to a [CToolTipCtrl](../vs140/ctooltipctrl-class.md) object to be used by the list control. If the [Create](../vs140/clistctrl--create.md) member function uses the style **LVS_NOTOOLTIPS**, no tooltips are used, and **NULL** is returned.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [LVM_GETTOOLTIPS](http://msdn.microsoft.com/library/windows/desktop/bb761085), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. The MFC implementation of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> returns a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object, which is used by the list control, rather than a handle to a tooltip control.  
  
## Example  
 [!code[NVC_MFC_CListCtrl#29](../vs140/codesnippet/CPP/clistctrl--gettooltips_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::SetToolTips](../vs140/clistctrl--settooltips.md)