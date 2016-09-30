---
title: "CTabCtrl::AdjustRect"
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
  - "CTabCtrl.AdjustRect"
  - "CTabCtrl::AdjustRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AdjustRect method"
ms.assetid: 84abe214-ff93-40bb-9dcb-b5038582136a
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabCtrl::AdjustRect
Calculates a tab control's display area given a window rectangle, or calculates the window rectangle that would correspond to a given display area.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Indicates which operation to perform. If this parameter is **TRUE**, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> specifies a display rectangle and receives the corresponding window rectangle. If this parameter is **FALSE**, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> specifies a window rectangle and receives the corresponding display rectangle.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that specifies the given rectangle and receives the calculated rectangle.  
  
## Example  
 [!code[NVC_MFC_CTabCtrl#1](../vs140/codesnippet/CPP/ctabctrl--adjustrect_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTabCtrl Class](../vs140/ctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTabCtrl::SetItemSize](../vs140/ctabctrl--setitemsize.md)   
 [CTabCtrl::GetItemRect](../vs140/ctabctrl--getitemrect.md)   
 [CTabCtrl::AdjustRect](../vs140/ctabctrl--adjustrect.md)