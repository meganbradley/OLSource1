---
title: "CListBox::SetHorizontalExtent"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CListBox::SetHorizontalExtent
  - CListBox.SetHorizontalExtent
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetHorizontalExtent method
  - CListBox class, general operations
ms.assetid: 6c7741c8-3006-4326-9d0f-3beba62e22fc
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CListBox::SetHorizontalExtent
Sets the width, in pixels, by which a list box can be scrolled horizontally.  
  
## Syntax  
  
```  
  
      void SetHorizontalExtent(  
   int cxExtent   
);  
```  
  
#### Parameters  
 *cxExtent*  
 Specifies the number of pixels by which the list box can be scrolled horizontally.  
  
## Remarks  
 If the size of the list box is smaller than this value, the horizontal scroll bar will horizontally scroll items in the list box. If the list box is as large or larger than this value, the horizontal scroll bar is hidden.  
  
 To respond to a call to `SetHorizontalExtent`, the list box must have been defined with the [WS_HSCROLL](../vs140/window-styles.md) style.  
  
 This member function is not useful for multicolumn list boxes. For multicolumn list boxes, call the `SetColumnWidth` member function.  
  
## Example  
 [!code[NVC_MFC_CListBox#33](../vs140/codesnippet/CPP/clistbox--sethorizontalextent_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::GetHorizontalExtent](../vs140/clistbox--gethorizontalextent.md)   
 [CListBox::SetColumnWidth](../vs140/clistbox--setcolumnwidth.md)   
 [LB_SETHORIZONTALEXTENT](http://msdn.microsoft.com/library/windows/desktop/bb761344)