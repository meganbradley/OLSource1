---
title: "CListBox::GetCaretIndex"
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
  - "CListBox::GetCaretIndex"
  - "CListBox.GetCaretIndex"
  - "GetCaretIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CListBox class, multiple-selection operations"
  - "GetCaretIndex method"
ms.assetid: cc5596c2-bbd8-4b16-ac2c-1da68d503b23
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::GetCaretIndex
Determines the index of the item that has the focus rectangle in a multiple-selection list box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The zero-based index of the item that has the focus rectangle in a list box. If the list box is a single-selection list box, the return value is the index of the item that is selected, if any.  
  
## Remarks  
 The item may or may not be selected.  
  
## Example  
 See the example for [CListBox::SetCaretIndex](../vs140/clistbox--setcaretindex.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::SetCaretIndex](../vs140/clistbox--setcaretindex.md)   
 [LB_GETCARETINDEX](http://msdn.microsoft.com/library/windows/desktop/bb775193)