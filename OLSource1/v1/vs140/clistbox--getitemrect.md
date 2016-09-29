---
title: "CListBox::GetItemRect"
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
  - "CListBox::GetItemRect"
  - "CListBox.GetItemRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemRect method [MFC]"
  - "CListBox class, general operations"
ms.assetid: d5b13975-84f7-492d-8009-31b07aeb148b
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::GetItemRect
Retrieves the dimensions of the rectangle that bounds a list-box item as it is currently displayed in the list-box window.  
  
## Syntax  
  
```  
  
      int GetItemRect(  
   int nIndex,  
   LPRECT lpRect   
) const;  
```  
  
#### Parameters  
 `nIndex`  
 Specifies the zero-based index of the item.  
  
 `lpRect`  
 Specifies a long pointer to a [RECT](../vs140/rect-structure.md) structure that receives the list-box client coordinates of the item.  
  
## Return Value  
 **LB_ERR** if an error occurs.  
  
## Example  
 [!code[NVC_MFC_CListBox#18](../vs140/codesnippet/CPP/clistbox--getitemrect_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LB_GETITEMRECT](http://msdn.microsoft.com/library/windows/desktop/bb775206)