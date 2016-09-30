---
title: "CListBox::GetAnchorIndex"
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
  - "CListBox::GetAnchorIndex"
  - "CListBox.GetAnchorIndex"
  - "GetAnchorIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CListBox class, multiple-selection operations"
  - "GetAnchorIndex method"
ms.assetid: ba2331d0-403f-4061-b905-b4b0f4314475
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::GetAnchorIndex
Retrieves the zero-based index of the current anchor item in the list box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The index of the current anchor item, if successful; otherwise **LB_ERR**.  
  
## Remarks  
 In a multiple-selection list box, the anchor item is the first or last item in a block of contiguous selected items.  
  
## Example  
 See the example for [CListBox::SetAnchorIndex](../vs140/clistbox--setanchorindex.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::SetAnchorIndex](../vs140/clistbox--setanchorindex.md)