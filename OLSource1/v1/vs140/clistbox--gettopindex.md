---
title: "CListBox::GetTopIndex"
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
  - "CListBox.GetTopIndex"
  - "CListBox::GetTopIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTopIndex method"
  - "CListBox class, general operations"
ms.assetid: 25c150a4-a559-4a0d-9729-f4b0373c46a9
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::GetTopIndex
Retrieves the zero-based index of the first visible item in a list box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The zero-based index of the first visible item in a list box if successful, **LB_ERR** otherwise.  
  
## Remarks  
 Initially, item 0 is at the top of the list box, but if the list box is scrolled, another item may be at the top.  
  
## Example  
 [!code[NVC_MFC_CListBox#22](../vs140/codesnippet/CPP/clistbox--gettopindex_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::SetTopIndex](../vs140/clistbox--settopindex.md)   
 [LB_GETTOPINDEX](http://msdn.microsoft.com/library/windows/desktop/bb761317)