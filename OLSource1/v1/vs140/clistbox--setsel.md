---
title: "CListBox::SetSel"
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
  - "CListBox::SetSel"
  - "CListBox.SetSel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CListBox class, multiple-selection operations"
  - "SetSel method"
ms.assetid: 34ff890c-f960-4173-8147-fea0da225fb4
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::SetSel
Selects a string in a multiple-selection list box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Contains the zero-based index of the string to be set. If –1, the selection is added to or removed from all strings, depending on the value of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies how to set the selection. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the string is selected and highlighted; if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the highlight is removed and the string is no longer selected. The specified string is selected and highlighted by default.  
  
## Return Value  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if an error occurs.  
  
## Remarks  
 Use this member function only with multiple-selection list boxes.  
  
 To select an item from a single-selection list box, use [CListBox::SetCurSel](../vs140/clistbox--setcursel.md).  
  
## Example  
 [!code[NVC_MFC_CListBox#38](../vs140/codesnippet/CPP/clistbox--setsel_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::GetSel](../vs140/clistbox--getsel.md)   
 [LB_SETSEL](http://msdn.microsoft.com/library/windows/desktop/bb761352)   
 [CListBox::SetCurSel](../vs140/clistbox--setcursel.md)