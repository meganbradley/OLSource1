---
title: "CToolBarCtrl::SetRows"
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
  - "CToolBarCtrl::SetRows"
  - "SetRows"
  - "CToolBarCtrl.SetRows"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRows method"
ms.assetid: c91aa1da-8da5-4cb5-be5a-c9938bb4a511
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::SetRows
Asks the toolbar control to resize itself to the requested number of rows.  
  
## Syntax  
  
```  
  
      void SetRows(  
   int nRows,  
   BOOL bLarger,  
   LPRECT lpRect   
);  
```  
  
#### Parameters  
 `nRows`  
 Requested number of rows.  
  
 `bLarger`  
 Tells whether to use more rows or fewer rows if the toolbar cannot be resized to the requested number of rows.  
  
 `lpRect`  
 Points to the [CRect](../vs140/crect-class.md) object or [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that will receive the new bounding rectangle of the toolbar.  
  
## Remarks  
 If the toolbar cannot resize itself to the requested number or rows, it will resize itself to either the next larger or next smaller valid size, depending on the value of `bLarger`. If `bLarger` is **TRUE**, the new number of rows will be larger than the number requested. If `bLarger` is **FALSE**, the new number of rows will be smaller than the number requested.  
  
 A given number of rows is valid for the toolbar if the buttons can be arranged such that all of the rows have the same number of buttons (except perhaps the last row). For example, a toolbar that contains four buttons could not be sized to three rows because the last two rows would have to be shorter. If you attempted to size it to three rows, you would get four rows if `bLarger` was **TRUE** and two rows if `bLarger` was **FALSE**.  
  
 If there are separators in the toolbar, the rules for when a given number of rows is valid are more complicated. The layout is computed such that button groups (buttons with a separator before the first and the last button in the group) are never broken up on several rows unless the group cannot fit on one row.  
  
 If a group does not fit on one row, the next group will start on the next row even if it would fit on the row where the large group ended. The purpose of this rule is to make the separation between large groups more noticeable. The resulting vertical separators are counted as rows.  
  
 Note also that the `SetRows` member function will always chose the layout that results in the smallest toolbar size. Creating a toolbar with the `TBSTYLE_WRAPABLE` style and then resizing the control will simply apply the method outlined above given the width of the control.  
  
 This function can only be called for toolbars that were created with the `TBSTYLE_WRAPABLE` style.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::Create](../vs140/ctoolbarctrl--create.md)   
 [CToolBarCtrl::GetRows](../vs140/ctoolbarctrl--getrows.md)