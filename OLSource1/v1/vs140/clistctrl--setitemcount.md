---
title: "CListCtrl::SetItemCount"
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
  - "CListCtrl.SetItemCount"
  - "SetItemCount"
  - "CListCtrl::SetItemCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetItemCount method"
ms.assetid: 90ef08b1-a7c8-44ae-8b13-e3955ddeac01
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SetItemCount
Prepares a list view control for adding a large number of items.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Number of items that the control will ultimately contain.  
  
## Remarks  
 To set the item count for a virtual list view control, see [CListCtrl::SetItemCountEx](../vs140/clistctrl--setitemcountex.md).  
  
## Remarks  
 This member function implements the behavior of the Win32 macro, [ListView_SetItemCount](http://msdn.microsoft.com/library/windows/desktop/bb775093), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CListCtrl#35](../vs140/codesnippet/CPP/clistctrl--setitemcount_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetItemCount](../vs140/clistctrl--getitemcount.md)   
 [CListCtrl::GetSelectedCount](../vs140/clistctrl--getselectedcount.md)