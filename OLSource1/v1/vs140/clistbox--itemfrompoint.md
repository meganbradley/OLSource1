---
title: "CListBox::ItemFromPoint"
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
  - "CListBox.ItemFromPoint"
  - "ItemFromPoint"
  - "CListBox::ItemFromPoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ItemFromPoint method"
  - "CListBox class, general operations"
ms.assetid: 2f4be783-9e0e-4601-b491-b6bab78db188
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::ItemFromPoint
Determines the list-box item nearest the point specified in <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Point for which to find the nearest item, specified relative to the upper-left corner of the client area of the list box.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Reference to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> variable which will be set to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is outside the client area of the nearest list box item, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is inside the client area of the nearest list box item.  
  
## Return Value  
 The index of the nearest item to the point specified in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Remarks  
 You could use this function to determine which list-box item the mouse cursor moves over.  
  
## Example  
 See the example for [CListBox::SetAnchorIndex](../vs140/clistbox--setanchorindex.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::GetItemRect](../vs140/clistbox--getitemrect.md)   
 [LB_ITEMFROMPOINT](http://msdn.microsoft.com/library/windows/desktop/bb761323)