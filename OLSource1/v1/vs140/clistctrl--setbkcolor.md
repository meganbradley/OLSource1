---
title: "CListCtrl::SetBkColor"
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
  - "CListCtrl::SetBkColor"
  - "CListCtrl.SetBkColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBkColor method"
ms.assetid: 0e5204fd-6410-4944-8c25-bead7b758eb9
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SetBkColor
Sets the background color of the list view control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Background color to set, or the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value for no background color. List view controls with background colors redraw themselves significantly faster than those without background colors. For information, see [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Example  
 [!code[NVC_MFC_CListCtrl#32](../vs140/codesnippet/CPP/clistctrl--setbkcolor_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetBkColor](../vs140/clistctrl--getbkcolor.md)